using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace VWT.User
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class AvatarNavigation : MonoBehaviour
    {
        public event Action ReachedTarget = delegate { };

        private NavMeshAgent _navMeshAgent;
        private AvatarState _state;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _state = GetComponent<AvatarState>();
        }

        public void MoveToTarget(Vector3 target)
        {
            _state.SetAi();
            StartCoroutine(Co_MovingToTarget(target));
        }

        private IEnumerator Co_MovingToTarget(Vector3 target)
        {
            _navMeshAgent.SetDestination(target);
            yield return new WaitUntil(() => !_navMeshAgent.pathPending && _navMeshAgent.remainingDistance < 0.1f);
            _state.SetManual();
            ReachedTarget.Invoke();
        }
    }
}