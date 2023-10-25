//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Resources/Input/InputSystem.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputSystem: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Moving"",
            ""id"": ""2bfa1620-cc95-42ab-bcab-345a5f3ca189"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""00083d25-8140-453a-bc42-ab51e028bbb5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""3faec35b-4799-40b6-8c14-a479095e8c20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4c2b8e89-52b9-4b31-bdf6-f7eae5d0ab1a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""36eeee47-6d8a-4229-82ca-d841889fc473"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""69e1e74f-e98f-4572-8672-cbb74ddba150"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50748b38-3705-4c86-91d1-cec9771bd3f4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6f5d4f1f-617b-4383-9467-3e419e99e8fc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b44144f-3c6c-4b61-86fc-0a8f0de4ff0a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""ff6a6546-2b73-4d44-aa1e-9d493369f31b"",
            ""actions"": [
                {
                    ""name"": ""RightMouseButton"",
                    ""type"": ""Button"",
                    ""id"": ""ac9331a2-51a3-4567-bc24-8a6e854f3d69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftMouseButton"",
                    ""type"": ""Button"",
                    ""id"": ""271af30e-5501-42ed-912b-81fcb82774b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2d8aed00-7636-4bc5-93c4-e486114cb109"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1580f904-0a82-4065-9631-213ca144628a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and keyboard"",
            ""bindingGroup"": ""Mouse and keyboard"",
            ""devices"": []
        }
    ]
}");
        // Moving
        m_Moving = asset.FindActionMap("Moving", throwIfNotFound: true);
        m_Moving_Move = m_Moving.FindAction("Move", throwIfNotFound: true);
        m_Moving_Dash = m_Moving.FindAction("Dash", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_RightMouseButton = m_Mouse.FindAction("RightMouseButton", throwIfNotFound: true);
        m_Mouse_LeftMouseButton = m_Mouse.FindAction("LeftMouseButton", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Moving
    private readonly InputActionMap m_Moving;
    private List<IMovingActions> m_MovingActionsCallbackInterfaces = new List<IMovingActions>();
    private readonly InputAction m_Moving_Move;
    private readonly InputAction m_Moving_Dash;
    public struct MovingActions
    {
        private @InputSystem m_Wrapper;
        public MovingActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Moving_Move;
        public InputAction @Dash => m_Wrapper.m_Moving_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Moving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovingActions set) { return set.Get(); }
        public void AddCallbacks(IMovingActions instance)
        {
            if (instance == null || m_Wrapper.m_MovingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovingActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
        }

        private void UnregisterCallbacks(IMovingActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
        }

        public void RemoveCallbacks(IMovingActions instance)
        {
            if (m_Wrapper.m_MovingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovingActions instance)
        {
            foreach (var item in m_Wrapper.m_MovingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovingActions @Moving => new MovingActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private List<IMouseActions> m_MouseActionsCallbackInterfaces = new List<IMouseActions>();
    private readonly InputAction m_Mouse_RightMouseButton;
    private readonly InputAction m_Mouse_LeftMouseButton;
    public struct MouseActions
    {
        private @InputSystem m_Wrapper;
        public MouseActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightMouseButton => m_Wrapper.m_Mouse_RightMouseButton;
        public InputAction @LeftMouseButton => m_Wrapper.m_Mouse_LeftMouseButton;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void AddCallbacks(IMouseActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseActionsCallbackInterfaces.Add(instance);
            @RightMouseButton.started += instance.OnRightMouseButton;
            @RightMouseButton.performed += instance.OnRightMouseButton;
            @RightMouseButton.canceled += instance.OnRightMouseButton;
            @LeftMouseButton.started += instance.OnLeftMouseButton;
            @LeftMouseButton.performed += instance.OnLeftMouseButton;
            @LeftMouseButton.canceled += instance.OnLeftMouseButton;
        }

        private void UnregisterCallbacks(IMouseActions instance)
        {
            @RightMouseButton.started -= instance.OnRightMouseButton;
            @RightMouseButton.performed -= instance.OnRightMouseButton;
            @RightMouseButton.canceled -= instance.OnRightMouseButton;
            @LeftMouseButton.started -= instance.OnLeftMouseButton;
            @LeftMouseButton.performed -= instance.OnLeftMouseButton;
            @LeftMouseButton.canceled -= instance.OnLeftMouseButton;
        }

        public void RemoveCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    private int m_MouseandkeyboardSchemeIndex = -1;
    public InputControlScheme MouseandkeyboardScheme
    {
        get
        {
            if (m_MouseandkeyboardSchemeIndex == -1) m_MouseandkeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and keyboard");
            return asset.controlSchemes[m_MouseandkeyboardSchemeIndex];
        }
    }
    public interface IMovingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnRightMouseButton(InputAction.CallbackContext context);
        void OnLeftMouseButton(InputAction.CallbackContext context);
    }
}
