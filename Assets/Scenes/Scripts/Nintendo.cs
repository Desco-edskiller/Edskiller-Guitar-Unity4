// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Nintendo.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Nintendo : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Nintendo()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Nintendo"",
    ""maps"": [
        {
            ""name"": ""Gamepad"",
            ""id"": ""582de488-3058-413c-a01d-ae86b7b44b5b"",
            ""actions"": [
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""ec5547fd-8072-4692-91b2-6bf5450a0d08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""ad792243-fa9d-4d13-a3c1-9e4d35fb47c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7fbbde39-185f-40ae-ac65-22783c7e8f58"",
                    ""path"": ""<SwitchProControllerHID>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c2db289-fe65-459d-b720-6ef8182c500d"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gamepad
        m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
        m_Gamepad_Right = m_Gamepad.FindAction("Right", throwIfNotFound: true);
        m_Gamepad_Left = m_Gamepad.FindAction("Left", throwIfNotFound: true);
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

    // Gamepad
    private readonly InputActionMap m_Gamepad;
    private IGamepadActions m_GamepadActionsCallbackInterface;
    private readonly InputAction m_Gamepad_Right;
    private readonly InputAction m_Gamepad_Left;
    public struct GamepadActions
    {
        private @Nintendo m_Wrapper;
        public GamepadActions(@Nintendo wrapper) { m_Wrapper = wrapper; }
        public InputAction @Right => m_Wrapper.m_Gamepad_Right;
        public InputAction @Left => m_Wrapper.m_Gamepad_Left;
        public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadActions instance)
        {
            if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
            {
                @Right.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnLeft;
            }
            m_Wrapper.m_GamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
            }
        }
    }
    public GamepadActions @Gamepad => new GamepadActions(this);
    public interface IGamepadActions
    {
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
    }
}
