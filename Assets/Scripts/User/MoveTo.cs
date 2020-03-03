using UnityEngine;

namespace CDA.User
{
    [RequireComponent(typeof(AvatarNavigation))]
    public class MoveTo : Interaction
    {
        private AvatarNavigation _navigation;

        private void Awake()
        {
            _navigation = GetComponent<AvatarNavigation>();
        }

        public override void Run(Interactable interactable)
        {
            interactable.Interact();
            _navigation.MoveToTarget(interactable.transform.position);
        }
    }
}