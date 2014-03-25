using UnityEngine;
using System.Collections;

public class MG_RefillSpray : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

    void OnCollisionEnter2D(Collision2D colInfo)
    {

        if (MG_ControlSpray.GetSprayRemaining() < 100 && Input.GetMouseButton(0))
        {

            MG_ControlSpray.AddSpray(5);

        }

        

    }
}
