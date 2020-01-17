using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform targetPoint;
    [Range(0, .9f)]
    public float moveSpeed;

    private void Start()
    {
        transform.position = spawnPoint.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, moveSpeed);

        if (Vector3.Distance(transform.position, targetPoint.position) < .25f)
        {
            transform.position = spawnPoint.position;
        }
    }
}
