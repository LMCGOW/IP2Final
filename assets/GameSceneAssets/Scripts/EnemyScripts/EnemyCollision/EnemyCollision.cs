using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        IgnoreTrashCollision();

	}

    void IgnoreTrashCollision()
    {

        Physics2D.IgnoreLayerCollision(9, 10);

    }

    
}
