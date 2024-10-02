using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayEx : MonoBehaviour
{
    [SerializeField] private Transform rayOrigin;
    [SerializeField] private float rayLenght;

    [SerializeField] private LayerMask rayMask;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out hit, rayLenght, rayMask))
        {
            Message.Log(Color.green, "Hit");
        }

        Debug.DrawRay(rayOrigin.position, rayOrigin.forward * rayLenght, Color.blue);
    }
}
