using UnityEngine;
using UnityEngine.InputSystem;
using InputCallback = UnityEngine.InputSystem.InputAction.CallbackContext;

namespace GBDKK
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D _rb2D;
        [SerializeField]
        private float _speed = 10;
        [SerializeField]
        private float _jumpForce = 90;
        [SerializeField]
        private InputActionAsset _asset;

        private float _horMoveAxis;
        private bool _shouldJump;

        public void HandleHorizontalInput(InputCallback context)
        {
            // handle horizontal input
            if (context.started)
            {
                Debug.Log($"Horizontal Input Started: {context.ReadValue<float>()}");
            }

            if (context.performed)
            {
                Debug.Log($"Horizontal Input Performed: {context.ReadValue<float>()}");
            }

            if (context.canceled)
            {
                Debug.Log($"Horizontal Input Canceled: {context.ReadValue<float>()}");
            }

            _horMoveAxis = context.ReadValue<float>();
        }

        public void HandleJumpInput(InputCallback context)
        {
            // handle jump input
            if (context.started)
            {
                Debug.Log($"Jump Input Started: ");
            }

            if (context.performed)
            {
                Debug.Log($"Jump Input Performed: ");
                _shouldJump = true;
            }

            if (context.canceled)
            {
                Debug.Log($"Jump Input Canceled: ");
            }
        }

        private void FixedUpdate()
        {
            Vector2 targetVelocity = new Vector2(_horMoveAxis * _speed, _rb2D.velocity.y);
            _rb2D.velocity = targetVelocity;

            if (_shouldJump)
            {
                _rb2D.AddForce(Vector2.up * _jumpForce);
                _shouldJump = false;
            }
        }
    }
}
