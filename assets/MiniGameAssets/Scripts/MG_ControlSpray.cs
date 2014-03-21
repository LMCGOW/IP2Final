using UnityEngine;
using System.Collections;

public class MG_ControlSpray : MonoBehaviour {

    float moveSpeed = 3f;

	// Use this for initialization
	void Start () {

     
        this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Screen.showCursor = false;

	}
	
	// Update is called once per frame
	void Update () {

       Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

	}

    void OnMouseDown()
    {

        this.transform.rotation = new Quaternion(0, 0, this.transform.rotation.x + 5, 0);
    }

    void OnMouseUp()
    {
        this.transform.rotation = new Quaternion(0, 0, this.transform.rotation.x - 5, 0);
    }
}
