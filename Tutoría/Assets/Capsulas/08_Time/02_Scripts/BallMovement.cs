using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float movSpeed;
    [SerializeField] private float rotSpeed;
    private float y;

    private void Update()
    {
        transform.position += transform.forward * movSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, y, 0);

        y += rotSpeed * Time.deltaTime;
    }
}
