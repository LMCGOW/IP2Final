using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.collider.tag == "Player")
        {
			//PlayerMovement.ChangeSpeed(-0.1f);
            SpawnTrash.RemoveTrash();
            PlayerScore.ChangeScore(1);
            Destroy(gameObject);
        }

    }
}
