using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagesToAppear : MonoBehaviour
{
    public GameObject[] images;
    public Transform spawnPosition;
    private int index;

    private void Start()
    {
        index = Random.Range(0, images.Length);
        Instantiate(images[index], spawnPosition);
    }
}
