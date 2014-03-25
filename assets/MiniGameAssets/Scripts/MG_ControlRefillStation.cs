using UnityEngine;
using System.Collections;

public class MG_ControlRefillStation : MonoBehaviour {

    Vector3 position;

	// Use this for initialization
	void Start () {

        this.position = this.transform.position;
        

	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position = position;
        this.transform.rotation = Quaternion.identity;

	}
}
