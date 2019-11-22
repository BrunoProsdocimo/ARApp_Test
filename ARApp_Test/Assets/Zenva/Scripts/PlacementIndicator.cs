using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class PlacementIndicator : MonoBehaviour
{
    public GameObject visual;
    public Trackable curTrackable;

    private void Start()
    {
        visual.SetActive(false);
    }

    private void Update()
    {
        TrackableHit hit;
        TrackableHitFlags filter = TrackableHitFlags.PlaneWithinPolygon;

        if(Frame.Raycast(Screen.width / 2, Screen.height / 2, filter, out hit))
        {
            curTrackable = hit.Trackable;

            transform.position = hit.Pose.position;
            transform.rotation = hit.Pose.rotation;

            visual.SetActive(true);
        }
        else
        {
            curTrackable = null;
            visual.SetActive(false);
        }
    }
}
