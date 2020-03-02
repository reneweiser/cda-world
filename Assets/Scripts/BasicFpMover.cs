using UnityEngine;

public class BasicFpMover : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 _moveDirection;

    [SerializeField] private float _speed = 6f;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _moveDirection = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal");
        _moveDirection *= _speed;
        _characterController.Move(_moveDirection * Time.deltaTime);
    }
}