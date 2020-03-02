using UnityEngine;

namespace CDA
{
    public class Entity : MonoBehaviour, IInteractable
    {
        private Material _material;

        public void Interact()
        {
            _material.color = Color.green;
        }

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
        }
    }
}