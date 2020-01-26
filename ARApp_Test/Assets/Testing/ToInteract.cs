using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;
using GoogleARCore;

public class ToInteract : MonoBehaviour
{
    public GameObject M_Image;
    private Camera cam;
    private bool checkMarkerIsOn;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && 
            Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == M_Image.GetComponent<Collider>())
                {
                    Destroy(M_Image);
                }

                /*if (hit.collider.gameObject != null && hit.collider.gameObject)
                {
                    switch (checkMarkerIsOn)
                    {
                        case true:
                            Deselect(M_Image);
                            break;
                        case false:
                            Select(M_Image);
                            break;
                    }
                }*/
            }
        }
    }

    void Select (GameObject selected)
    {
        ToggleSelectionVisual(selected, true);
        checkMarkerIsOn = true;
    }

    void Deselect(GameObject selected)
    {
        ToggleSelectionVisual(selected, false);
        checkMarkerIsOn = false;
    }

    void ToggleSelectionVisual (GameObject obj, bool toggle)
    {
        M_Image.transform.Find("CheckMark").gameObject.SetActive(toggle);
    }
}
