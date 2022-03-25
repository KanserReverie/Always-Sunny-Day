using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericRPG
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform target;

        // Update is called once per frame
        void Update()
        {
            transform.position = target.position;
        }
    }
}