using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace CDA.User
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class AvatarNavigation : MonoBehaviour
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

        public void MoveToTarget(Vector3 target)
        {
            _navMeshAgent.isStopped = false;
            _mover.enabled = false;
            _rotator.enabled = false;
            StartCoroutine(Co_MovingToTarget(target));
        }

        private IEnumerator Co_MovingToTarget(Vector3 target)
        {
            _navMeshAgent.SetDestination(target);
            yield return new WaitUntil(() => !_navMeshAgent.pathPending && _navMeshAgent.remainingDistance < 0.1f);
            Debug.Log("Reached Target");
            _navMeshAgent.isStopped = true;
            _mover.enabled = true;
            _rotator.enabled = true;
        }
    }
}