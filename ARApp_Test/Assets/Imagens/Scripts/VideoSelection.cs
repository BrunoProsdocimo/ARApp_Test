using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSelection : MonoBehaviour
{
    public VideoClip[] videosArray;
    private int index;
    private VideoClip clip;

    private void Start()
    {
        index = Random.Range(0, videosArray.Length);
        GetComponent<VideoPlayer>().clip = videosArray[index];
    }
}
