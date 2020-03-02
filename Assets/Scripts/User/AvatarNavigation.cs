using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace CDA.User
{
    public class AvatarNavigation : MonoBehaviour
    {
        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        public void MoveToTarget(Vector3 target)
        {
            StartCoroutine(Co_MovingToTarget(target));
        }

        private IEnumerator Co_MovingToTarget(Vector3 target)
        {
            _navMeshAgent.SetDestination(target);
            yield return new WaitUntil(() => !_navMeshAgent.pathPending && _navMeshAgent.remainingDistance < 0.1f);
            Debug.Log("Reached Target");
        }
    }
}