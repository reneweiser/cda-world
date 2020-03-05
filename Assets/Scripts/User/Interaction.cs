using System;
using System.Threading.Tasks;
using UnityEngine;

namespace VWT.User
{
    public abstract class Interaction : MonoBehaviour
    {
        public abstract Task Run(Interactable interactable);
    }
}