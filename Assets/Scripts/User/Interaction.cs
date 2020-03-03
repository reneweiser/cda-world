using UnityEngine;

namespace CDA.User
{
    public abstract class Interaction : MonoBehaviour
    {
        public abstract void Run(Interactable interactable);
    }
}