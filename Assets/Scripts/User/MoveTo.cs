using System.Threading.Tasks;
using UnityEngine;

namespace VWT.User
{
    [RequireComponent(typeof(AvatarNavigation))]
    public class MoveTo : Interaction
    {
        private AvatarNavigation _navigation;
        private TaskCompletionSource<bool> _signal;

        private void Awake()
        {
            _navigation = GetComponent<AvatarNavigation>();
            _navigation.ReachedTarget += () => _signal.SetResult(true);
        }

        public override async Task Run(Interactable interactable)
        {
            _signal = new TaskCompletionSource<bool>();
            interactable.Interact();
            _navigation.MoveToTarget(interactable.transform.position);
            await _signal.Task;
        }
    }
}