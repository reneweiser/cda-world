using VWT.User;
using UnityEngine;

namespace VWT
{
    public class Entity : Interactable
    {
        private Material _material;

        public override void Interact()
        {
            _material.color = Color.yellow;
        }

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
        }
    }
}