using GBDKK.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GBDKK.Test
{
    public class InputSystemTest : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 15;
        [SerializeField]
        private float maxVelocity = 20;
        [SerializeField]
        private float _movementSmoothing = .5f;
        [SerializeField]
        private float _jumpPower = 300;
        [SerializeField]
        private float _jumpHeight = 7;
        [SerializeField]
        private Rigidbody2D _rb2D;

        private TestControl _inputActionMap;
        private float _horMoveAxis;
        private bool _shouldJump;
        private Vector2 _refVelocity;

        private void OnEnable()
        {
            if (_inputActionMap == null)
                _inputActionMap = new TestControl();

            _inputActionMap.Char.HorMovement.started += HandleHorMovement;
            _inputActionMap.Char.HorMovement.performed += HandleHorMovement;
            _inputActionMap.Char.HorMovement.canceled += HandleHorMovement;
            _inputActionMap.Char.Jump.performed += HandleJump;
            _inputActionMap.Enable();
        }

        private void OnDisable()
        {
            _inputActionMap.Char.HorMovement.started -= HandleHorMovement;
            _inputActionMap.Char.HorMovement.performed -= HandleHorMovement;
            _inputActionMap.Char.HorMovement.canceled -= HandleHorMovement;
            _inputActionMap.Char.Jump.performed -= HandleJump;
        }

        private void HandleHorMovement(InputAction.CallbackContext context)
        {
            Debug.Log($"Move context: {context.phase}. Time: {context.time:0.00}");

            _horMoveAxis = context.ReadValue<float>();
            Debug.Log($"Move Horizontal Axis {_horMoveAxis}");
        }

        private void HandleJump(InputAction.CallbackContext context)
        {
            _shouldJump = true;
            //_rb2D.AddForce(Vector2.up * Mathf.Sqrt(_jumpHeight * -2f * Physics2D.gravity.y), ForceMode2D.Impulse);
            Debug.Log("Jump Called");
        }

        private void FixedUpdate()
        {
            //if (Mathf.Abs(_rb2D.velocity.magnitude) < maxVelocity)
            //{
            //    _rb2D.AddForce(new Vector2(_horMoveAxis * _speed, 0));
            //}

            Vector2 targetVelocity = new Vector2(_horMoveAxis * _speed, 0);
            _rb2D.velocity =
                Vector2.SmoothDamp(_rb2D.velocity, targetVelocity, ref _refVelocity, _movementSmoothing);

            if (_shouldJump)
            {
                _rb2D.AddForce(Vector2.up * _jumpPower);
                _shouldJump = false;
            }

            //_rb2D.MovePosition(_rb2D.position + (Vector2.right * _horMoveAxis * _speed * Time.fixedDeltaTime));
        }
    }
}


