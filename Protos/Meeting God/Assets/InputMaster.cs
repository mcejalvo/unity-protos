// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cbedb286-b8d4-4127-b542-6c23a0955ca4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""642212dc-9b5a-4b52-800c-9d27ce4e83f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlatformSpawn"",
                    ""type"": ""Button"",
                    ""id"": ""5a53ee39-2978-41e4-97bb-27a238cdb617"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""d24d9504-17f2-4993-8825-8e44fc531e24"",
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
                    ""id"": ""c6b26208-34b3-438a-a492-7f76b32601c4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""10c71c5a-2153-4eb9-bba7-0bbf2755aa4c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""63ea9d36-b096-462a-9133-7ac8bf602ea1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c8ec395a-a989-489c-9811-344686102f82"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""574b2ecd-625f-46bc-a380-81a70ab5c7c1"",
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
                    ""id"": ""d3c0942d-e3df-4a2c-9823-14204e6ac80d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c20c477c-8dff-4336-999b-550fec5966c6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d7420dd9-5af4-4d1a-81f5-a0dd34c907ce"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7ce329fd-dc66-4aae-be86-948f3d953550"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2c0e4459-3bdf-4fea-bc9e-e3107c33e0ec"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlatformSpawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Setting"",
            ""id"": ""0fdecddc-94ca-440c-ba85-9c9e167244f0"",
            ""actions"": [
                {
                    ""name"": ""PlatformSpawn"",
                    ""type"": ""Button"",
                    ""id"": ""d18e6486-3c08-4987-a4d1-7af9df05ff6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScreenPosition"",
                    ""type"": ""Button"",
                    ""id"": ""d8257ee3-0336-4c40-bddc-cd9fbef719ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f83cc728-8303-4ee6-ac02-6823dbedc078"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlatformSpawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71f1a55b-7e84-4788-be84-b3a243220919"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScreenPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_PlatformSpawn = m_Player.FindAction("PlatformSpawn", throwIfNotFound: true);
        // Setting
        m_Setting = asset.FindActionMap("Setting", throwIfNotFound: true);
        m_Setting_PlatformSpawn = m_Setting.FindAction("PlatformSpawn", throwIfNotFound: true);
        m_Setting_ScreenPosition = m_Setting.FindAction("ScreenPosition", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_PlatformSpawn;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @PlatformSpawn => m_Wrapper.m_Player_PlatformSpawn;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @PlatformSpawn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlatformSpawn;
                @PlatformSpawn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlatformSpawn;
                @PlatformSpawn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlatformSpawn;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @PlatformSpawn.started += instance.OnPlatformSpawn;
                @PlatformSpawn.performed += instance.OnPlatformSpawn;
                @PlatformSpawn.canceled += instance.OnPlatformSpawn;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Setting
    private readonly InputActionMap m_Setting;
    private ISettingActions m_SettingActionsCallbackInterface;
    private readonly InputAction m_Setting_PlatformSpawn;
    private readonly InputAction m_Setting_ScreenPosition;
    public struct SettingActions
    {
        private @InputMaster m_Wrapper;
        public SettingActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlatformSpawn => m_Wrapper.m_Setting_PlatformSpawn;
        public InputAction @ScreenPosition => m_Wrapper.m_Setting_ScreenPosition;
        public InputActionMap Get() { return m_Wrapper.m_Setting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SettingActions set) { return set.Get(); }
        public void SetCallbacks(ISettingActions instance)
        {
            if (m_Wrapper.m_SettingActionsCallbackInterface != null)
            {
                @PlatformSpawn.started -= m_Wrapper.m_SettingActionsCallbackInterface.OnPlatformSpawn;
                @PlatformSpawn.performed -= m_Wrapper.m_SettingActionsCallbackInterface.OnPlatformSpawn;
                @PlatformSpawn.canceled -= m_Wrapper.m_SettingActionsCallbackInterface.OnPlatformSpawn;
                @ScreenPosition.started -= m_Wrapper.m_SettingActionsCallbackInterface.OnScreenPosition;
                @ScreenPosition.performed -= m_Wrapper.m_SettingActionsCallbackInterface.OnScreenPosition;
                @ScreenPosition.canceled -= m_Wrapper.m_SettingActionsCallbackInterface.OnScreenPosition;
            }
            m_Wrapper.m_SettingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlatformSpawn.started += instance.OnPlatformSpawn;
                @PlatformSpawn.performed += instance.OnPlatformSpawn;
                @PlatformSpawn.canceled += instance.OnPlatformSpawn;
                @ScreenPosition.started += instance.OnScreenPosition;
                @ScreenPosition.performed += instance.OnScreenPosition;
                @ScreenPosition.canceled += instance.OnScreenPosition;
            }
        }
    }
    public SettingActions @Setting => new SettingActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPlatformSpawn(InputAction.CallbackContext context);
    }
    public interface ISettingActions
    {
        void OnPlatformSpawn(InputAction.CallbackContext context);
        void OnScreenPosition(InputAction.CallbackContext context);
    }
}
