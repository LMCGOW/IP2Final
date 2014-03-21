using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    float defaultSize = 3f;

    int minSize = 1;
    int maxSize = 5;

    float change = 0.2f;

	// Use this for initialization
	void Start () {

        Camera.main.orthographicSize = defaultSize;

	}
	
	// Update is called once per frame
	void Update () {

        CameraZoom();

	}

    void CameraZoom()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            Camera.main.orthographicSize -= change;

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            Camera.main.orthographicSize += change;

        if (Camera.main.orthographicSize < minSize)
            Camera.main.orthographicSize = minSize;

        if (Camera.main.orthographicSize > maxSize)
            Camera.main.orthographicSize = maxSize;

    }
}
