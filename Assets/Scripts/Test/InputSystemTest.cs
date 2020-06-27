using GBDKK.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GBDKK.Test
{
    public class InputSystemTest : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 10;
        [SerializeField]
        private float _jumpPower = 30;
        [SerializeField]
        private Rigidbody2D _rb2D;

        private TestControl _inputActionMap;
        private float _horMoveAxis;
        private bool _shouldJump;

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
            Debug.Log("Jump Called");
        }

        private void FixedUpdate()
        {
            if (_shouldJump)
            {
                _rb2D.AddForce(Vector2.up * _jumpPower);
                _shouldJump = false;
            }

            _rb2D.AddForce(new Vector2(_horMoveAxis * _speed, 0));
            //_rb2D.MovePosition(_rb2D.position + new Vector2(_horMoveAxis * Time.deltaTime * _speed, 0));
        }
    }
}


