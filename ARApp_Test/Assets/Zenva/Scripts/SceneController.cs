﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class SceneController : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public PlacementIndicator placementIndicator;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (placementIndicator.curTrackable != null)
            {
                Pose pose = new Pose(placementIndicator.transform.position, placementIndicator.transform.rotation);

                Anchor anchor = placementIndicator.curTrackable.CreateAnchor(pose);

                GameObject obj = Instantiate(prefabToSpawn, pose.position, pose.rotation, anchor.transform);
            }
        }
    }
}
