using UnityEngine;

namespace VWT.Input
{
    public class KeyboardMouseInput : InputHandler
    {
        public override bool IsDragging => UnityEngine.Input.GetMouseButton(0);

        public override bool Interact => UnityEngine.Input.GetMouseButtonUp(1);

        public override float MoveForward => UnityEngine.Input.GetAxis("Vertical");

        public override float MoveRight => UnityEngine.Input.GetAxis("Horizontal");

        public override float LookUp => UnityEngine.Input.GetAxis("Mouse Y");

        public override float Turn => UnityEngine.Input.GetAxis("Mouse X");

        public override Vector2 CursorPosition => UnityEngine.Input.mousePosition;
    }
}