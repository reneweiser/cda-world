using UnityEngine;

namespace CDA
{
    public class Entity : MonoBehaviour, IInteractable
    {
        private Material _material;

        public void Interact()
        {
            _material.color = Color.yellow;
        }

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
        }
    }
}