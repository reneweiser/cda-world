using UnityEngine;
using UnityEngine.AI;

namespace VWT.User
{
    public class AvatarState : MonoBehaviour
    {
        private NavMeshAgent _navMeshAgent;
        private AvatarMover _mover;
        private CameraRotator _rotator;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _mover = GetComponent<AvatarMover>();
            _rotator = GetComponent<CameraRotator>();
        }

        private void Start()
        {
            SetManual();
        }

        public void SetManual()
        {
            _navMeshAgent.enabled = false;
            _mover.enabled = true;
            _rotator.enabled = true;
        }

        public void SetAi()
        {
            _navMeshAgent.enabled = true;
            _mover.enabled = false;
            _rotator.enabled = false;
        }
    }
}