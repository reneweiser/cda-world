using UnityEngine;

namespace CDA.User
{
    public abstract class InputHandler : MonoBehaviour
    {
        public abstract bool IsDragging { get; }
        public abstract float MoveForward { get; }
        public abstract float MoveRight { get; }
        public abstract float LookUp { get; }
        public abstract float Turn { get; }
    }
}