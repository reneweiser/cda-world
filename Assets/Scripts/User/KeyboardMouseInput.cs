using UnityEngine;

namespace CDA.User
{
    public class KeyboardMouseInput : InputHandler
    {
        public override bool IsDragging => Input.GetMouseButton(0);

        public override bool Interact => Input.GetMouseButtonUp(1);

        public override float MoveForward => Input.GetAxis("Vertical");

        public override float MoveRight => Input.GetAxis("Horizontal");

        public override float LookUp => Input.GetAxis("Mouse Y");

        public override float Turn => Input.GetAxis("Mouse X");
    }
}