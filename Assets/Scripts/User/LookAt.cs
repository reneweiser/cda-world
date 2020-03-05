using System.Threading.Tasks;
using UnityEngine;

namespace VWT.User
{
    public class LookAt : Interaction
    {
        [SerializeField] private Camera _camera;

        public override async Task Run(Interactable interactable)
        {
            _camera.transform.position = interactable.transform.position + new Vector3(0, 1f, -1f);
            _camera.transform.rotation = Quaternion.LookRotation(
                (interactable.transform.position - _camera.transform.position).normalized,
                Vector3.up
            );
            await Task.Delay(1000); // Will be replaced by tweening function
        }
    }
}