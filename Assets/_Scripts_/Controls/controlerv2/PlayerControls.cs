// GENERATED AUTOMATICALLY FROM 'Assets/_Scripts_/Controls/controlerv2/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""103016bf-f13d-4984-95ee-9ea852ef73af"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3a104717-07df-4b2a-af31-6d2753dd1809"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c4111492-8dad-4936-98b3-cadaf37801b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b1727d67-de44-4ff6-b40c-4080f069e2d0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aed2d451-2709-4589-a488-3f2b7300c430"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""PassThrough"",
                    ""id"": ""19102227-f5af-4db3-8ac9-127a377cc869"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c3b81461-e061-4269-baf9-af899938e8c2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2f67fe07-8ca8-4d16-b736-966e34d46eae"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f94058ec-3f3e-47e1-b174-b6185d4f1677"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""428a0aa5-1041-4f24-afdf-0ddf6fdbb470"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""411e43e6-225c-42c2-b1ef-f1dfad9d13b5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5c6a05bd-a220-47f6-a637-158d50baa706"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a0af35c-2d4e-42d1-b1a0-03b57f09b36c"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b915abca-cb9b-4a28-aa6d-8f9480679ddb"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a21c93d4-3460-43d0-ba36-f721b5f57707"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interactions"",
            ""id"": ""30b29ce1-2991-405b-9799-d14adeb71bbe"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e175269e-9dc5-45b7-b3dc-faf2a8710164"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""2ed54cbe-aead-4e9b-8dc4-3e3de6c9fe3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootSeries"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1881a152-092f-4a36-aff5-1b81130a4642"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a4f6c0dd-b37a-463c-8f29-48c2a2b60afd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""043b58ef-b695-4a00-87e4-b29108515943"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""00d456b4-a3f6-4093-89f1-8cefd59147c3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""f2ceb3f7-6483-4503-af6c-d26431ea858e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TorchSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""56732684-d14c-48aa-8fac-05bf75aab1fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""863bcedc-c0b3-46b8-b2ec-03a14646f11f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mission"",
                    ""type"": ""Button"",
                    ""id"": ""bf727efe-caf6-4fc8-94aa-f372988ebd0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShowGun"",
                    ""type"": ""Button"",
                    ""id"": ""bfac36b7-7d60-4008-b749-8b499ce2448b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1f501b25-c9a1-413d-88a6-7c00c8b8514c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1220384c-0761-45a5-ad7c-6d5f7171724c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a01f22db-2646-4521-81b2-ad26af7964d5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootSeries"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de47132d-63c8-47e0-b12f-0e337aafd3e8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96a3e8da-4305-4964-856f-b02b446ca238"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74608ea6-ea56-44d3-b492-7ee222bb54bd"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f13af61d-75be-4c83-a219-f715b223324b"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fdf6ebb-2680-49b3-bf9f-cd6ee67fa8d5"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TorchSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc4dfa34-2e97-42fd-b44e-0f5fe1b11ec9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f6352cd-8de4-4aef-b5a5-735ed3630b45"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mission"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96fb003a-29e1-4b93-a025-018480b623cd"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShowGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""f957a060-be1b-492d-a682-f2d9bef60e01"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""11beef37-9c65-4a1f-b4ac-02d5f69e3dd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08d01464-f3e4-4cfd-813e-5181e5cbc81d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_HorizontalMovement = m_GroundMovement.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_GroundMovement_Jump = m_GroundMovement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMovement_MouseX = m_GroundMovement.FindAction("MouseX", throwIfNotFound: true);
        m_GroundMovement_MouseY = m_GroundMovement.FindAction("MouseY", throwIfNotFound: true);
        m_GroundMovement_Sprint = m_GroundMovement.FindAction("Sprint", throwIfNotFound: true);
        // Interactions
        m_Interactions = asset.FindActionMap("Interactions", throwIfNotFound: true);
        m_Interactions_Shoot = m_Interactions.FindAction("Shoot", throwIfNotFound: true);
        m_Interactions_Reload = m_Interactions.FindAction("Reload", throwIfNotFound: true);
        m_Interactions_ShootSeries = m_Interactions.FindAction("ShootSeries", throwIfNotFound: true);
        m_Interactions_Interact = m_Interactions.FindAction("Interact", throwIfNotFound: true);
        m_Interactions_Drop = m_Interactions.FindAction("Drop", throwIfNotFound: true);
        m_Interactions_Aim = m_Interactions.FindAction("Aim", throwIfNotFound: true);
        m_Interactions_Map = m_Interactions.FindAction("Map", throwIfNotFound: true);
        m_Interactions_TorchSwitch = m_Interactions.FindAction("TorchSwitch", throwIfNotFound: true);
        m_Interactions_Esc = m_Interactions.FindAction("Esc", throwIfNotFound: true);
        m_Interactions_Mission = m_Interactions.FindAction("Mission", throwIfNotFound: true);
        m_Interactions_ShowGun = m_Interactions.FindAction("ShowGun", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private IGroundMovementActions m_GroundMovementActionsCallbackInterface;
    private readonly InputAction m_GroundMovement_HorizontalMovement;
    private readonly InputAction m_GroundMovement_Jump;
    private readonly InputAction m_GroundMovement_MouseX;
    private readonly InputAction m_GroundMovement_MouseY;
    private readonly InputAction m_GroundMovement_Sprint;
    public struct GroundMovementActions
    {
        private @PlayerControls m_Wrapper;
        public GroundMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_GroundMovement_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_GroundMovement_Jump;
        public InputAction @MouseX => m_Wrapper.m_GroundMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GroundMovement_MouseY;
        public InputAction @Sprint => m_Wrapper.m_GroundMovement_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @Sprint.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_GroundMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);

    // Interactions
    private readonly InputActionMap m_Interactions;
    private IInteractionsActions m_InteractionsActionsCallbackInterface;
    private readonly InputAction m_Interactions_Shoot;
    private readonly InputAction m_Interactions_Reload;
    private readonly InputAction m_Interactions_ShootSeries;
    private readonly InputAction m_Interactions_Interact;
    private readonly InputAction m_Interactions_Drop;
    private readonly InputAction m_Interactions_Aim;
    private readonly InputAction m_Interactions_Map;
    private readonly InputAction m_Interactions_TorchSwitch;
    private readonly InputAction m_Interactions_Esc;
    private readonly InputAction m_Interactions_Mission;
    private readonly InputAction m_Interactions_ShowGun;
    public struct InteractionsActions
    {
        private @PlayerControls m_Wrapper;
        public InteractionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Interactions_Shoot;
        public InputAction @Reload => m_Wrapper.m_Interactions_Reload;
        public InputAction @ShootSeries => m_Wrapper.m_Interactions_ShootSeries;
        public InputAction @Interact => m_Wrapper.m_Interactions_Interact;
        public InputAction @Drop => m_Wrapper.m_Interactions_Drop;
        public InputAction @Aim => m_Wrapper.m_Interactions_Aim;
        public InputAction @Map => m_Wrapper.m_Interactions_Map;
        public InputAction @TorchSwitch => m_Wrapper.m_Interactions_TorchSwitch;
        public InputAction @Esc => m_Wrapper.m_Interactions_Esc;
        public InputAction @Mission => m_Wrapper.m_Interactions_Mission;
        public InputAction @ShowGun => m_Wrapper.m_Interactions_ShowGun;
        public InputActionMap Get() { return m_Wrapper.m_Interactions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionsActions instance)
        {
            if (m_Wrapper.m_InteractionsActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShoot;
                @Reload.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnReload;
                @ShootSeries.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShootSeries;
                @ShootSeries.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShootSeries;
                @ShootSeries.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShootSeries;
                @Interact.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Drop.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnDrop;
                @Aim.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnAim;
                @Map.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnMap;
                @TorchSwitch.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnTorchSwitch;
                @TorchSwitch.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnTorchSwitch;
                @TorchSwitch.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnTorchSwitch;
                @Esc.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnEsc;
                @Mission.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnMission;
                @Mission.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnMission;
                @Mission.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnMission;
                @ShowGun.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShowGun;
                @ShowGun.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShowGun;
                @ShowGun.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnShowGun;
            }
            m_Wrapper.m_InteractionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @ShootSeries.started += instance.OnShootSeries;
                @ShootSeries.performed += instance.OnShootSeries;
                @ShootSeries.canceled += instance.OnShootSeries;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
                @TorchSwitch.started += instance.OnTorchSwitch;
                @TorchSwitch.performed += instance.OnTorchSwitch;
                @TorchSwitch.canceled += instance.OnTorchSwitch;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
                @Mission.started += instance.OnMission;
                @Mission.performed += instance.OnMission;
                @Mission.canceled += instance.OnMission;
                @ShowGun.started += instance.OnShowGun;
                @ShowGun.performed += instance.OnShowGun;
                @ShowGun.canceled += instance.OnShowGun;
            }
        }
    }
    public InteractionsActions @Interactions => new InteractionsActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Click;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IGroundMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
    public interface IInteractionsActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnShootSeries(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
        void OnTorchSwitch(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
        void OnMission(InputAction.CallbackContext context);
        void OnShowGun(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
