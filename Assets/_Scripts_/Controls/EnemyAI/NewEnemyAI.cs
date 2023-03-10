using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewEnemyAI : MonoBehaviour
{

    [Header("Karma")]
    public BossKarma bossKarma;
    public static float moveSpeed = 4f;
    [SerializeField]
    public static float runningSpeed = 6f;
    [SerializeField]
    public static float attackDamage = 5;
    [SerializeField]
    public static float Health = 10;
    [SerializeField]
    public static int enemyKilled = 0;

    [Header("Sound")]
    #region setup
    public AudioSource audioSource;
    public SoundManager soundManager;
    public List<GameObject> enemyBlood = new List<GameObject>();
    private float waitTimer = 3f;
    public bool checkingNoise;
    // The target transform (i.e. the player)
    public Transform target;

    // The range at which the enemy can see the player
    public float detectionRange = 10f;

    // The range at which the enemy will stop chasing the player
    public float loseSightRange = 15f;

    public float attackRange = 1.5f;
    private float timeSinceLastAttack = 0.0f;
    public float attackRate = 1f;
    public float fieldOfViewAngle = 200f;
    public List<Transform> patrolPoints;
    private int currentPatrolPointIndex = 0;
    private Animator animator;
    private NavMeshAgent navMeshAgent;
    private Movement movement;

    public bool Alive;
    public bool Alerted;
    public bool Attacking;
    float distanceToTarget;
    public float thisDamageTaken;
    // public float initialHealth;
    #endregion
    private void Awake()
    {
        gameObject.tag = "Enemy";
        soundManager = FindObjectOfType<SoundManager>();
        bossKarma = FindObjectOfType<BossKarma>();
        movement = FindObjectOfType<Movement>();

        // Try to get the existing AudioSource component
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            // If an AudioSource component does not exist, add one and assign it to the variable
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        // Set the playOnAwake property to false
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 1;
    }

    private void Start()
    {
        // Get reference to Animator and NavMeshAgent components
        animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        Alive = true;
        Alerted = false;
    }

    private void Update()
    {
        timeSinceLastAttack += Time.deltaTime;
        distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (Alive)
        {

            if (!Alerted)
            {
                if (checkingNoise)
                {
                    if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance && Alive)
                    {
                        StartCoroutine(WaitAtDestination());
                    }
                    else
                    {
                        PlaySound(SoundType.Walk);
                    }
                }
                else if (patrolPoints.Count != 0 && !checkingNoise && Alive)
                {
                    animator.SetFloat("locomotion", 1f, 0.4f, Time.deltaTime);
                    PlaySound(SoundType.Walk);
                    // Check if the enemy has reached its current patrol point
                    if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
                    {

                        // Increment the current patrol point index
                        currentPatrolPointIndex = (currentPatrolPointIndex + 1) % patrolPoints.Count;

                        // Set the enemy's destination to the next patrol point
                        navMeshAgent.SetDestination(patrolPoints[currentPatrolPointIndex].position);
                    }
                }
                else
                {
                    animator.SetFloat("locomotion", 0f, 0.4f, Time.deltaTime);
                }
            }

            // If the player is within the detection range and the enemy's field of view
            if (distanceToTarget < detectionRange && IsInFieldOfView())
            {
                Alerted = true;

                if (distanceToTarget >= attackRange)
                {// Set the enemy's destination to the player's position
                    navMeshAgent.SetDestination(target.position);
                    animator.SetBool("Attack", false);
                    navMeshAgent.speed = runningSpeed;
                    animator.SetFloat("locomotion", 2f);
                    PlaySound(SoundType.Run);
                }
                else if (distanceToTarget <= attackRange)
                {
                    animator.SetFloat("locomotion", 0f);
                    StartCoroutine(Attack());
                }
                // else
                // {
                //     animator.SetBool("Attack", false);
                //     navMeshAgent.speed = runningSpeed;
                //     animator.SetFloat("locomotion", 2f);
                //     PlaySound(SoundType.Run);
                // }
            }
            else if (Alerted && distanceToTarget < detectionRange && !IsInFieldOfView())
            {
                animator.SetBool("Attack", false);
                navMeshAgent.speed = runningSpeed;
                animator.SetFloat("locomotion", 2f);
                navMeshAgent.SetDestination(target.position);
                PlaySound(SoundType.Run);
            }
            else if (distanceToTarget > detectionRange && !IsInFieldOfView())
            {
                Alerted = false;
                navMeshAgent.speed = moveSpeed;
            }
        }
    }

    private bool IsInFieldOfView()
    {
        // Calculate the angle between the enemy's forward direction and the direction to the player
        float angleToTarget = Vector3.Angle(transform.forward, target.position - transform.position);
        // Check if there is an obstacle blocking the line of sight
        RaycastHit hit;
        if (Physics.Linecast(transform.position, target.position, out hit))
        {
            // Return false if the line of sight is blocked by an object
            if (hit.collider.CompareTag("Player"))
            {
                // Return true if the angle is within the enemy's field of view
                return angleToTarget < fieldOfViewAngle * 0.5f;
            }
            else
                return false;
        }

        return angleToTarget < fieldOfViewAngle * 0.5f;
    }

    public void Stun()
    {
        if (!animator.GetBool("Attack") && !Alerted && Alive)
        {
            Alive = false;
            animator.SetBool("Die", true);
            PlaySound(SoundType.Stun);
            navMeshAgent.SetDestination(this.transform.position);

            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<NewEnemyAI>().enabled = false;

        }
    }

    private IEnumerator Attack()
    {
        if (timeSinceLastAttack < attackRate)
        {
            yield break;
        }

        if (distanceToTarget < attackRange)
        {
            animator.SetBool("Attack", true);
            PlaySound(SoundType.MeeleAttack);
            timeSinceLastAttack = 0.0f;
            new WaitForSeconds(1);
            if (distanceToTarget < attackRange)
            {
                movement.TakeDamage(attackDamage);
            }
            yield break;
        }
        else
        {
            animator.SetBool("Attack", false);
            yield return new WaitForSeconds(attackRate);
        }


    }

    public void CheckNoise(Vector3 noiseSourcePosition)
    {
        if (Alive)
        {
            animator.SetFloat("locomotion", 1f);
            navMeshAgent.SetDestination(noiseSourcePosition);
            checkingNoise = true;
        }
    }

    private IEnumerator WaitAtDestination()
    {
        var timePassed = 0f;
        animator.SetFloat("locomotion", 0f);

        while (timePassed < waitTimer)
        {
            var factor = timePassed / waitTimer;
            navMeshAgent.isStopped = true;
            // increae by the time passed since last frame
            timePassed += Time.deltaTime;

            yield return null;
        }

        navMeshAgent.isStopped = false;
        checkingNoise = false;
    }

    public Quaternion bloodRotation;
    public void Die()
    {
        if (Alive)
        {
            Alive = false;
            animator.SetBool("Die", true);
            navMeshAgent.SetDestination(this.transform.position);
            navMeshAgent.isStopped = true;
            bloodRotation.x = 0;
            bloodRotation.y = 90;
            bloodRotation.z = 0;
            int enemyBloodType = Random.Range(0, enemyBlood.Count);
            Instantiate(enemyBlood[enemyBloodType], transform.position, bloodRotation);
            enemyKilled++;
            PlaySound(SoundType.Die);
            bossKarma.useEnemyKarma();

            GetComponent<Collider>().enabled = false;
            GetComponentInChildren<Collider>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<NewEnemyAI>().enabled = false;
        }
    }

    public void TakeDamage(int damage)
    {
        thisDamageTaken += damage;

        float outCome = Health - thisDamageTaken;
        Debug.Log("thisDamageTaken " + thisDamageTaken);
        Debug.Log("outCome " + outCome);
        Debug.Log("Health " + Health);
        if (outCome <= 0)
        {
            Die();
        }
        PlaySound(SoundType.TookDamage);
    }

    private void PlaySound(SoundType soundType)
    {
        soundManager.PlaySound(audioSource, soundType);
    }
}
