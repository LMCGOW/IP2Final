using UnityEngine;
using System.Collections;

public class OpenGateOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerScore.SafeScore >= 20)
            Destroy(gameObject);

	}
}
