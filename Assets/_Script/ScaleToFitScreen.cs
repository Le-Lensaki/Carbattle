using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleToFitScreen : MonoBehaviour
{
    public SpriteRenderer sr;

    private void Start()
    {
        Camera camera = GetComponent<Camera>();

        Debug.Log(Screen.width);
        float zoom = camera.orthographicSize;
        zoom =  sr.bounds.size.x * Screen.height / Screen.width * 0.5f;
        camera.orthographicSize = zoom;

    }

} 
