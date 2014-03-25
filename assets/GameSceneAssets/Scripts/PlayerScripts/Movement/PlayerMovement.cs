using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 4;
    public Vector2 vel;

    static bool respawn = false;

    public static Vector3 playerSpawn;

    public bool forwardAnimation;
    public bool backwardAnimation;
    public bool rightAnimation;
    public bool leftAnimation;
    public bool idle;

    public GameObject[] animationFrames = new GameObject[4];

	public GameObject trash;

	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        MovePlayer();
        LockCameraToPlayer();
        //AnimatePlayer();

		if (speed < 2.0f)
			speed = 2.0f;

        if (respawn)
        {
            this.transform.position = playerSpawn;
            respawn = false;
        }

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
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            vel = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        }
        else
        {
            vel = new Vector2(0, 0);
        }

        rigidbody2D.velocity = vel;
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
        else if (collisionInfo.collider.tag == "EnemyHarder")
        {
            if (PlayerScore.Score >= 5)
            {
                ChangeSpeed(0.5f);
            }
            else
            {
                ChangeSpeed(0.1f * PlayerScore.Score);
            }

            PlayerScore.ChangeScore(-10);

        }
    }

    void AnimatePlayer()
    {


    }

    public static void respawnPlayer()
    {
        respawn = true;
    }

}
