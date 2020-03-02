using UnityEngine;

namespace CDA.User
{
    public class Interactor : MonoBehaviour
    {
        [SerializeField] private InputHandler _input;
        [SerializeField] private Camera _camera;
        [SerializeField] private AvatarNavigation _navigation;

        private void Update()
        {
            if (_input.Interact)
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    Transform objectHit = hit.transform;

                    var interactable = objectHit.GetComponent<IInteractable>();
                    if (interactable != null)
                    {
                        interactable.Interact();
                        _navigation.MoveToTarget(objectHit.position);
                    }
                }
            }
        }
    }
}