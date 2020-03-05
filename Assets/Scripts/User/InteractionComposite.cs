using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace VWT.User
{
    public class InteractionComposite : Interaction
    {
        [SerializeField] private List<Interaction> _interactions;

        public override async Task Run(Interactable interactable)
        {
            foreach (var interaction in _interactions)
            {
                await interaction.Run(interactable);
            }
        }
    }
}