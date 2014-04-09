using UnityEngine;
using System.Collections;

public class MG_CameraControl : MonoBehaviour {

    float speed = 0.5f;

    int minSize = 1;
    int maxSize = 15;

    float change = 1f;

	// Use this for initialization
	void Start () {
	
		Camera.main.orthographicSize = maxSize;

	}
	
	// Update is called once per frame
	void Update () {

        MoveCamera();
        ZoomCamera();

	}

    void MoveCamera()
    {
        if (Input.GetMouseButton(2))
        {
            Vector3 CameraPos;

            float MouseX;
            float MouseY;

            MouseX = Input.GetAxis("Mouse X");
            MouseY = Input.GetAxis("Mouse Y");
            CameraPos = new Vector3(-MouseX*speed, -MouseY*speed, 0);

            Camera.main.transform.position += CameraPos;
        }

    }

    void ZoomCamera()
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

