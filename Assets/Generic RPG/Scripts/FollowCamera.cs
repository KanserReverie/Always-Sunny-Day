using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericRPG
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform target;

        // Late Update is called once per frame after the player moves :)
        private void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}