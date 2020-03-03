using CDA.Input;
using UnityEngine;

namespace CDA.User
{
    public class AvatarMover : MonoBehaviour
    {
        private CharacterController _characterController;
        private Vector3 _moveDirection;

        [SerializeField] private float _speed = 100f;
        [SerializeField] private InputHandler _input;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            _moveDirection = transform.forward * _input.MoveForward + transform.right * _input.MoveRight;
            _moveDirection *= _speed;
            _characterController.SimpleMove(_moveDirection * Time.deltaTime);
        }
    }
}