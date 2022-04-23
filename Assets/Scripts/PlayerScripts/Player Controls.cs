// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerScripts/Player Controls.inputactions'

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
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Player Movenemt"",
            ""id"": ""8e3b483e-45d0-4d28-b6e5-534e7aef09c1"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""33ca1b28-326a-4929-a1ed-a5718d81d900"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""190aeef2-01d6-4987-9198-4ae4c15295c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""deca6c00-4c83-4685-a833-871d6f13b561"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""13ed6b3e-e79f-4447-b6a6-16e2d953031d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc300692-8462-4323-8a3e-2fd173f22f8d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aa83e031-5b2b-4dc6-bf78-4612bdc13678"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8c24e4fb-a125-4c4b-abb2-64cc6a9d4491"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""5b1c2df6-8e17-4dd4-8609-7e975d8b26a3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""321bc171-076a-4666-862f-e8a96204cfdd"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""178d241d-5617-4038-9195-c75c8a87ce37"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""20e8bb3d-715c-4166-a164-5a88e7025785"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d40180cf-7319-4685-b68e-c332ec06e047"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0d257ff7-d8b7-4586-8dae-feb14ab8e92d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right Stick (mouse)"",
                    ""id"": ""dc121c5e-3395-48f3-af93-6517047fa5d5"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a5471a4f-cf70-4e51-a7c0-a2252cf22889"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""daf4ad76-ad75-45c4-8cc1-437ddb5bca29"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""54c553cc-81c0-436a-8a0b-c1e644d3a1be"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0ede453d-4476-4986-982b-e57ef86c1af3"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Parry"",
            ""id"": ""3360f9b3-d21c-4d41-a32c-5140bdfb5266"",
            ""actions"": [
                {
                    ""name"": ""Blocking"",
                    ""type"": ""Button"",
                    ""id"": ""6c0b0e22-0cae-49bf-ae11-1a664fbc7a57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BlockingRelease"",
                    ""type"": ""Button"",
                    ""id"": ""d88c7356-a24d-48ff-aab6-83cfc671772c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06f7b61b-4dbf-49a2-a5fe-a54f70b8f78f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(pressPoint=0.5,behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlockingRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18652b75-b6c6-4e12-ab87-791a1405ac7b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blocking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""864d9f44-1d33-4714-91ff-c08e10adfef0"",
            ""actions"": [
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""6a37492f-a6e7-4d9d-b9d5-903e1a52d17c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""018641af-4a3e-45af-a44d-856d7bd56347"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ea9b028-055b-435f-ba6f-917495dcd296"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movenemt
        m_PlayerMovenemt = asset.FindActionMap("Player Movenemt", throwIfNotFound: true);
        m_PlayerMovenemt_Movement = m_PlayerMovenemt.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovenemt_Camera = m_PlayerMovenemt.FindAction("Camera", throwIfNotFound: true);
        // Parry
        m_Parry = asset.FindActionMap("Parry", throwIfNotFound: true);
        m_Parry_Blocking = m_Parry.FindAction("Blocking", throwIfNotFound: true);
        m_Parry_BlockingRelease = m_Parry.FindAction("BlockingRelease", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_Hit = m_Debug.FindAction("Hit", throwIfNotFound: true);
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

    // Player Movenemt
    private readonly InputActionMap m_PlayerMovenemt;
    private IPlayerMovenemtActions m_PlayerMovenemtActionsCallbackInterface;
    private readonly InputAction m_PlayerMovenemt_Movement;
    private readonly InputAction m_PlayerMovenemt_Camera;
    public struct PlayerMovenemtActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovenemtActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovenemt_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovenemt_Camera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovenemt; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovenemtActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovenemtActions instance)
        {
            if (m_Wrapper.m_PlayerMovenemtActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovenemtActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovenemtActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovenemtActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerMovenemtActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerMovenemtActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerMovenemtActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_PlayerMovenemtActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public PlayerMovenemtActions @PlayerMovenemt => new PlayerMovenemtActions(this);

    // Parry
    private readonly InputActionMap m_Parry;
    private IParryActions m_ParryActionsCallbackInterface;
    private readonly InputAction m_Parry_Blocking;
    private readonly InputAction m_Parry_BlockingRelease;
    public struct ParryActions
    {
        private @PlayerControls m_Wrapper;
        public ParryActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Blocking => m_Wrapper.m_Parry_Blocking;
        public InputAction @BlockingRelease => m_Wrapper.m_Parry_BlockingRelease;
        public InputActionMap Get() { return m_Wrapper.m_Parry; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ParryActions set) { return set.Get(); }
        public void SetCallbacks(IParryActions instance)
        {
            if (m_Wrapper.m_ParryActionsCallbackInterface != null)
            {
                @Blocking.started -= m_Wrapper.m_ParryActionsCallbackInterface.OnBlocking;
                @Blocking.performed -= m_Wrapper.m_ParryActionsCallbackInterface.OnBlocking;
                @Blocking.canceled -= m_Wrapper.m_ParryActionsCallbackInterface.OnBlocking;
                @BlockingRelease.started -= m_Wrapper.m_ParryActionsCallbackInterface.OnBlockingRelease;
                @BlockingRelease.performed -= m_Wrapper.m_ParryActionsCallbackInterface.OnBlockingRelease;
                @BlockingRelease.canceled -= m_Wrapper.m_ParryActionsCallbackInterface.OnBlockingRelease;
            }
            m_Wrapper.m_ParryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Blocking.started += instance.OnBlocking;
                @Blocking.performed += instance.OnBlocking;
                @Blocking.canceled += instance.OnBlocking;
                @BlockingRelease.started += instance.OnBlockingRelease;
                @BlockingRelease.performed += instance.OnBlockingRelease;
                @BlockingRelease.canceled += instance.OnBlockingRelease;
            }
        }
    }
    public ParryActions @Parry => new ParryActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_Hit;
    public struct DebugActions
    {
        private @PlayerControls m_Wrapper;
        public DebugActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hit => m_Wrapper.m_Debug_Hit;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @Hit.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnHit;
                @Hit.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnHit;
                @Hit.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnHit;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Hit.started += instance.OnHit;
                @Hit.performed += instance.OnHit;
                @Hit.canceled += instance.OnHit;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    public interface IPlayerMovenemtActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
    public interface IParryActions
    {
        void OnBlocking(InputAction.CallbackContext context);
        void OnBlockingRelease(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnHit(InputAction.CallbackContext context);
    }
}
