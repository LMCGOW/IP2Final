using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 4;
    public Vector2 vel;

	public GameObject trash;

    bool moving;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

        MovePlayer();
        LockCameraToPlayer();

		if (speed < 2.0f)
			speed = 2.0f;

	}
	

	public void ResetSpeed()
	{
		speed = 4;
	}

	public void ChangeSpeed(float delta)
    {

		speed += delta;

	}
	

    void MovePlayer()
    {
        vel = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        if (vel.magnitude > 0)
        {
            moving = true;
        }
        rigidbody2D.velocity = vel;
        /*
        if (Input.GetKey(KeyCode.W))
        {
            this.rigidbody2D.velocity = (new Vector2(0, speed));
            moving = true;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            this.rigidbody2D.velocity = (new Vector2(0, -speed));
            moving = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.rigidbody2D.velocity = (new Vector2(speed, 0));
            moving = true;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            this.rigidbody2D.velocity = (new Vector2(-speed, 0));
            moving = true;
        }
        */

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W))
        {
            moving = false;
        }

        if (!moving)
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }
    }

    void LockCameraToPlayer()
    {

        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Camera.main.transform.position.z);

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
			if(PlayerScore.Score >= 5)
			{
				ChangeSpeed(0.5f);
			}
			else
			{
				ChangeSpeed(0.1f * PlayerScore.Score);
			}

			PlayerScore.ChangeScore(-5);
        }
    }
}
