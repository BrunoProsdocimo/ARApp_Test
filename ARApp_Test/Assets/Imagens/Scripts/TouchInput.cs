using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.LegacyInputHelpers;
using UnityEngine.EventSystems;

public class TouchInput : MonoBehaviour
{
    private Camera cam;
    private bool selectedImage = default;
    public ObjReference videoPlayer;
    // public ObjReference objReference;
    // public GameObject baseImage;
    // public GameObject checkMark;
    

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
                if (hit.collider.gameObject != null)
                {

                    switch (selectedImage)
                    {
                        case true:
                            videoPlayer.checkMarker.SetActive(false);
                            break;
                        case false:
                            videoPlayer.checkMarker.SetActive(true);
                            break;
                        default:
                            break;
                                
                    }
                }

                // If the object the Raycast hit has checkMarker...
                // checkMarker.SetActive(true);

                //objReference.checkMarker.SetActive(true);
            }
        }
    }
}
