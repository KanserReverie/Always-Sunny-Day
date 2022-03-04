using UnityEngine;
using UnityEngine.AI;

namespace GenericRPG
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private Transform target;
        private NavMeshAgent playerNavMeshAgent;
        // Start is called before the first frame update
        void Start()
        {
            playerNavMeshAgent = GetComponent<NavMeshAgent>();

            if(playerNavMeshAgent == null)
                playerNavMeshAgent = GetComponentInChildren<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            playerNavMeshAgent.SetDestination(target.position);
        }
    }
}