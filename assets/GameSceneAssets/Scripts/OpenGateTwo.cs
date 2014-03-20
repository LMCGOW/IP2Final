using UnityEngine;
using System.Collections;

public class OpenGateTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerScore.SafeScore >= 40)
            Destroy(gameObject);

	}
}
