using UnityEngine;

namespace VWT.Input
{
    public abstract class InputHandler : MonoBehaviour
    {
        public virtual bool IsDragging => false;
        public virtual bool Interact => false;
        public virtual Vector3 MoveTo => Vector3.zero;
        public virtual Vector2 CursorPosition => Vector2.zero;
        public virtual float MoveForward => 0f;
        public virtual float MoveRight => 0f;
        public virtual float LookUp => 0f;
        public virtual float Turn => 0f;
    }
}