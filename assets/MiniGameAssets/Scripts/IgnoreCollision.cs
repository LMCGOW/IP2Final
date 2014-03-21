using UnityEngine;
using System.Collections;

public class IgnoreCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Physics2D.IgnoreLayerCollision(14, 9); //make sure spray doesn't collide with trash
		Physics2D.IgnoreLayerCollision(8, 8); //make sure enemies can pass through eachother
	}
}
