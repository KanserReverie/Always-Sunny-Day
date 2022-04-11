using UnityEngine;
using UnityEngine.AI;

namespace GenericRPG
{
    public class Mover : MonoBehaviour
    {
        private NavMeshAgent playerNavMeshAgent;
        private Animator playerAnimator;
        private Camera mainCamera;
        // Start is called before the first frame update
        private void Start()
        {
            playerAnimator = GetComponentInChildren<Animator>();
            playerNavMeshAgent = GetComponentInChildren<NavMeshAgent>();
            mainCamera = Camera.main; // Gets the main camera.
        }

        // Update is called once per frame
        private void Update()
        {
            if(Input.GetMouseButton(0)) MoveToCursor();// Gets left mouse button 
            UpdateAnimator();
        }

        private void MoveToCursor()
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition); // Gets the mouse position.
            RaycastHit hit;
            bool hasHit = Physics.Raycast(ray, out hit);
            if(hasHit)
                playerNavMeshAgent.SetDestination(hit.point);
        }
        
        private void UpdateAnimator()
        {
            Vector3 velocity = playerNavMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity); // Need this to convert to the direction the player is moving on a plane.
            float speed = localVelocity.z;
            playerAnimator.SetFloat("forwardSpeed", speed);
        }
    }
}