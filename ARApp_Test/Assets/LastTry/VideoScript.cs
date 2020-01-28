using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoScript : MonoBehaviour
{
    public bool isSelected;
    public GameObject checkMarker;

    public void showMarker()
    {
        if (isSelected == true)
        {
            checkMarker.SetActive(true);
        }
        else
        {
            checkMarker.SetActive(false);
        }
    }
}
