using UnityEngine;

namespace VWT.Input
{
    public class InteractInput : InputHandler
    {
        public override bool Interact => UnityEngine.Input.GetMouseButtonUp(1);

        public override Vector2 CursorPosition => UnityEngine.Input.mousePosition;
    }
}