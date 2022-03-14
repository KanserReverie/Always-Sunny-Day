using UnityEngine;
using UnityEngine.AI;

namespace GenericRPG
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private Transform target;
        private NavMeshAgent playerNavMeshAgent;

        private Camera mainCamera;
        // Start is called before the first frame update
        void Start()
        {
            playerNavMeshAgent = GetComponentInChildren<NavMeshAgent>();
            mainCamera = Camera.main; // Gets the main camera.
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0)) MoveToCursor();// Gets left mouse button 
        }

        private void MoveToCursor()
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition); // Gets the mouse position.
            RaycastHit hit;
            bool hasHit = Physics.Raycast(ray, out hit);
            if(hasHit)
                playerNavMeshAgent.SetDestination(hit.point);
        }
    }
}