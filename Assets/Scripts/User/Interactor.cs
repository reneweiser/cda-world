using VWT.Input;
using UnityEngine;

namespace VWT.User
{
    public class Interactor : MonoBehaviour
    {
        [SerializeField] private InputHandler _input;
        [SerializeField] private Camera _camera;
        [SerializeField] private Interaction _interaction;
        [SerializeField] private Interaction _lookInteraction;

        private void Update()
        {
            if (_input.Interact)
            {
                Ray ray = _camera.ScreenPointToRay(_input.CursorPosition);

                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    Transform objectHit = hit.transform;

                    var interactable = objectHit.GetComponent<Interactable>();
                    if (interactable != null)
                    {
                        Test(interactable);
                    }
                }
            }
        }

        private async void Test(Interactable i)
        {
            await _interaction.Run(i);
            await _lookInteraction.Run(i);
            Debug.Log("target reached");
        }
    }
}