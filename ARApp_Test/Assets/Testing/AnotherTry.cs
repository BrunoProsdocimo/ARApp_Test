using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;


public class AnotherTry : MonoBehaviour
{
    public GameObject Miguel;
    private Camera cam;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.touchCount > 0 &&
            Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject != null && hit.collider.gameObject == Miguel)
                {
                    Destroy(Miguel);
                }
            }
        }
    }
}
