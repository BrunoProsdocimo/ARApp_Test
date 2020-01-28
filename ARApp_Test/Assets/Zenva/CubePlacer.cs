﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.LegacyInputHelpers;
using UnityEngine.EventSystems;
using GoogleARCore;

public class CubePlacer : MonoBehaviour
{
    private List<GameObject> cube = new List<GameObject>();
    private GameObject curSelected;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
        {
            Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject != null && cube.Contains(hit.collider.gameObject))
                {
                    if (curSelected != null && hit.collider.gameObject != curSelected)
                    {
                        Select(curSelected);

                    }
                    else if (curSelected == null)
                    {
                        Select(hit.collider.gameObject);
                    }
                }
            }
        }
    }

    public void PlaceCube(GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
        cube.Add(obj);
        Select(obj);
    }

    void Select (GameObject selected)
    {
        if (curSelected != null)
            ToggleSelectionVisual(curSelected, false);

        curSelected = selected;
        ToggleSelectionVisual(curSelected, true);
    }

    void Deselect()
    {
        if (curSelected != null)
            ToggleSelectionVisual(curSelected, false);
        curSelected = null;
    }

    void ToggleSelectionVisual (GameObject obj, bool toggle)
    {
        obj.transform.Find("Selected").gameObject.SetActive(toggle);
    }
}