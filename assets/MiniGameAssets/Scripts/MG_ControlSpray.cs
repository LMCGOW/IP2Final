using UnityEngine;
using System.Collections;

public class MG_ControlSpray : MonoBehaviour {

    float moveSpeed = 3f;
    static float sprayRemaining = 100;

	// Use this for initialization
	void Start () {

     
        this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);


	}
	
	// Update is called once per frame
	void Update () {

       Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

       if (Input.GetMouseButton(0))
       {
           RemoveSpray();
       }

       if (sprayRemaining <= 0)
           sprayRemaining = 0;

	}

    /// <summary>
    /// When called, this will begin to deplete the spray can
    /// </summary>
    public static void RemoveSpray()
    {

        sprayRemaining -= 0.5f;

    }

    public static float GetSprayRemaining()
    {
        return sprayRemaining;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 40, 150, 20), "Spray remaining: " + sprayRemaining); 
    }
}
