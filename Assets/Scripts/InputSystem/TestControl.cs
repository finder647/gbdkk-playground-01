// GENERATED AUTOMATICALLY FROM 'Assets/Presets/Input System/Test_01 Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GBDKK.InputSystem
{
    public class @TestControl : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TestControl()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Test_01 Controls"",
    ""maps"": [
        {
            ""name"": ""Char"",
            ""id"": ""3f3f742f-8521-409c-bfeb-ea34f8d995df"",
            ""actions"": [
                {
                    ""name"": ""HorMovement"",
                    ""type"": ""Value"",
                    ""id"": ""04fa9d67-1b26-457d-9203-ffbdae4faaff"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bedafe9a-424f-4c60-8848-50c1f7fd7461"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""c6e01954-3722-41ca-8d10-b3c4d7e1d61d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7b441a9d-0429-454f-906f-0146016aef15"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""aa776d6b-a457-4196-a58d-e4e64c207bbf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""cddb31dd-c326-4c6f-b22a-c79a130121e7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e59e051b-0cae-4e7e-82d8-0a1e8b294ce5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""18237892-78fb-422c-9b70-1620fc0405d8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""5faebaac-9372-4e51-a5c8-24c197132c9f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fa1f40b0-51c1-4d41-b44a-1921768aa36e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7ab274c9-8dc4-43eb-9fa1-635008460568"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftJoystick"",
                    ""id"": ""f45f860c-0771-4073-b034-7fc0bdeeef82"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b0b078a9-1638-44e8-8d5c-bad4d87401d2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""73ced07f-cea8-4fff-a385-e9013025e9e2"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""48131b3d-2563-49cd-809c-a1712a265c25"",
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
                    ""id"": ""28afec03-23cf-4691-8cbe-c6198925a367"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Char
            m_Char = asset.FindActionMap("Char", throwIfNotFound: true);
            m_Char_HorMovement = m_Char.FindAction("HorMovement", throwIfNotFound: true);
            m_Char_Jump = m_Char.FindAction("Jump", throwIfNotFound: true);
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

        // Char
        private readonly InputActionMap m_Char;
        private ICharActions m_CharActionsCallbackInterface;
        private readonly InputAction m_Char_HorMovement;
        private readonly InputAction m_Char_Jump;
        public struct CharActions
        {
            private @TestControl m_Wrapper;
            public CharActions(@TestControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @HorMovement => m_Wrapper.m_Char_HorMovement;
            public InputAction @Jump => m_Wrapper.m_Char_Jump;
            public InputActionMap Get() { return m_Wrapper.m_Char; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CharActions set) { return set.Get(); }
            public void SetCallbacks(ICharActions instance)
            {
                if (m_Wrapper.m_CharActionsCallbackInterface != null)
                {
                    @HorMovement.started -= m_Wrapper.m_CharActionsCallbackInterface.OnHorMovement;
                    @HorMovement.performed -= m_Wrapper.m_CharActionsCallbackInterface.OnHorMovement;
                    @HorMovement.canceled -= m_Wrapper.m_CharActionsCallbackInterface.OnHorMovement;
                    @Jump.started -= m_Wrapper.m_CharActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_CharActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_CharActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_CharActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HorMovement.started += instance.OnHorMovement;
                    @HorMovement.performed += instance.OnHorMovement;
                    @HorMovement.canceled += instance.OnHorMovement;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public CharActions @Char => new CharActions(this);
        public interface ICharActions
        {
            void OnHorMovement(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
    }
}
