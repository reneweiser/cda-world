using UnityEngine;

namespace CDA.User
{
    public class Interactor : MonoBehaviour
    {
        [SerializeField] private InputHandler _input;
        [SerializeField] private Camera _camera;

        private void Update()
        {
            if (_input.Interact)
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    Transform objectHit = hit.transform;

                    objectHit.GetComponent<IInteractable>()?.Interact();
                }
            }
        }
    }
}