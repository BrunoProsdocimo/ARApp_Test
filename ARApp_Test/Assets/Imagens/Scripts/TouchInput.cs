using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.LegacyInputHelpers;
using UnityEngine.EventSystems;

public class TouchInput : MonoBehaviour
{
    // public GameObject baseImage;
    // public GameObject checkMark;
    private Camera cam;
    public ObjReference objReference;
    

    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // If the object the Raycast hit has checkMarker...
                // checkMarker.SetActive(true);

                //objReference.checkMarker.SetActive(true);
            }
        }
    }

    //public void PlaceCheckMarker (GameObject checkMarker)
    //{
    //}
}
