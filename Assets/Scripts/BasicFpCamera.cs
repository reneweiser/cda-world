using UnityEngine;

public class BasicFpCamera : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _body;
    [SerializeField] private float _pitchMin = -60f;
    [SerializeField] private float _pitchMax = 60f;
    [SerializeField] private float _sensitivity = 2f;

    private float _pitchDelta = 0f;
    private float _yawDelta = 0f;

    private void Update()
    {
        if (!Input.GetMouseButton(1)) return;
        _pitchDelta += Input.GetAxis("Mouse Y") * _sensitivity;
        _yawDelta += Input.GetAxis("Mouse X") * _sensitivity;

        _pitchDelta = Mathf.Clamp(_pitchDelta, _pitchMin, _pitchMax);

        _camera.transform.localEulerAngles = new Vector3(-_pitchDelta, 0f, 0f);
        _body.eulerAngles = new Vector3(0f, _yawDelta, 0f);
    }
}