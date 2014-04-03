using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	public AudioClip[] trashPickup;

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
			audio.clip = trashPickup[Random.Range(0, trashPickup.Length)];
			audio.Play();
			gameObject.renderer.enabled = false;
			StartCoroutine(WaitAndDestroy(audio.clip.length));
        }

    }

	IEnumerator WaitAndDestroy (float waitTime) 
	{

		yield return new WaitForSeconds(waitTime);
		Destroy(gameObject);

	}
}
