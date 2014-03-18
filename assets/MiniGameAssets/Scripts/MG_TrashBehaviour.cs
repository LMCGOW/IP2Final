using UnityEngine;
using System.Collections;

public class MG_TrashBehaviour : MonoBehaviour {

    float speed = 1f;

    public GameObject background;
    public GameObject enemy;

    public bool collidingWithTrash = false;

    public Vector3 endPosition;

    GameObject[] enemies;

	// Use this for initialization
	void Start () {

        endPosition.x = (background.renderer.bounds.size.x / 2) - 1;

	}
	
	// Update is called once per frame
	void Update () {

		this.rigidbody2D.velocity = new Vector3 (speed, 0, 0);

        CheckIfDead();

	}

    void CheckIfDead()
    {

        if(this.transform.position.x >= endPosition.x){
            Destroy(gameObject);
            MG_ShowScore.AddScore(1);
        }

    }

	void OnCollisionEnter2D(Collision2D colInfo)
	{
		Destroy (gameObject);
	}


  
}
