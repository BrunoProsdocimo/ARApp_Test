using UnityEngine;

public class LastTry : MonoBehaviour
{
    public Camera cam;
    VideoScript[] videosInScene;
    Vector2 touchPosition = default;
    int index;


    private void Start()
    {
        cam = Camera.main;
        videosInScene = FindObjectsOfType<VideoScript>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = cam.ScreenPointToRay(touch.position);
                RaycastHit hitObj;
                if (Physics.Raycast(ray, out hitObj))
                {
                    var selection = hitObj.transform.gameObject;
                    if (selection.CompareTag("VideoPlayer"))
                    {
                        
                    }
                }
            }
        }
    }

    void Selection(VideoScript selectedVideo)
    {
        foreach (VideoScript videosArray in videosInScene)
        {
            selectedVideo = videosArray;
            if (videosArray.isSelected == false)
            {
                videosArray.isSelected = true;
                videosArray.showMarker();
            }
            else
            {
                videosArray.isSelected = false;
                videosArray.showMarker();
            }
        }
    }
}
