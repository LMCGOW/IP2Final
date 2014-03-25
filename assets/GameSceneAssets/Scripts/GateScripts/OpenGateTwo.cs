using UnityEngine;
using System.Collections;

public class OpenGateTwo : MonoBehaviour {

    public GameObject roadObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerScore.SafeScore >= 40)
        {
            Instantiate(roadObject, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

	}


}
