using UnityEngine;

namespace CDA.User
{
    public class BasicFpCamera : MonoBehaviour
    {
        [SerializeField] private Transform _body;
        [SerializeField] private Camera _camera;
        [SerializeField] private InputHandler _input;
        [SerializeField] private float _pitchMax = 60f;
        [SerializeField] private float _pitchMin = -60f;
        [SerializeField] private float _sensitivity = 2f;
        private float _pitchDelta = 0f;
        private float _yawDelta = 0f;

        private void Update()
        {
            if (_input.IsDragging)
            {
                _pitchDelta += _input.LookUp * _sensitivity;
                _yawDelta += _input.Turn * _sensitivity;

                _pitchDelta = Mathf.Clamp(_pitchDelta, _pitchMin, _pitchMax);

                _camera.transform.localEulerAngles = new Vector3(-_pitchDelta, 0f, 0f);
                _body.eulerAngles = new Vector3(0f, _yawDelta, 0f);
            }
        }
    }
}