using UnityEngine;
using UnityEngine.AI;

namespace GenericRPG
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private Transform target;
        private NavMeshAgent playerNavMeshAgent;

        private Camera mainCamera;
        private Ray lastRay;
        // Start is called before the first frame update
        void Start()
        {
            playerNavMeshAgent = GetComponent<NavMeshAgent>();

            mainCamera = Camera.main;
            if(playerNavMeshAgent == null)
                playerNavMeshAgent = GetComponentInChildren<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                MoveToCursor();
            }
            lastRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            playerNavMeshAgent.SetDestination(target.position);
        }

        private void MoveToCursor()
        {
            
        }
    }
}