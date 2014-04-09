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

			GameObject.Find("_GameManager").GetComponent<PlayerScore>().play = true;

			//gameObject.renderer.enabled = false;
			Destroy(gameObject);
			//StartCoroutine(WaitAndDestroy(audio.clip.length));
        }

    }

	/*IEnumerator WaitAndDestroy (float waitTime) 
	{

		yield return new WaitForSeconds(waitTime);
		Destroy(gameObject);

	}*/
}
