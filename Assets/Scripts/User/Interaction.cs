using UnityEngine;

namespace VWT.User
{
    public abstract class Interaction : MonoBehaviour
    {
        public abstract void Run(Interactable interactable);
    }
}