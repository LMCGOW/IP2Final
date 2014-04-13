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

	public Texture2D hitScreen;

    Animator animator;
    bool isHit = false;
	bool flashScreen = false;
    float isHitTimer = 0.3f;

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();
        

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(speed);

        MovePlayer();
        LockCameraToPlayer();
        //AnimatePlayer();

		// minimum speed cap
		if (speed < 2.0f)
			speed = 2.0f;

		// maximum speed cap
		if (speed > 4.0f)
			speed = 4.0f;

        if (respawn)
        {
            this.transform.position = playerSpawn;
            respawn = false;
        }

        /*if (isHit)
        {
            isHitTimer -= Time.deltaTime;

            if (PlayerScore.Score >= 5)
            {
                animator.Play("IsHit 0");
            }

            if (isHitTimer <= 0)
            {
                isHit = false;
                isHitTimer = 0.3f;
            }
        }*/

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
        /*if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            vel = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        }
        else
        {
            vel = new Vector2(0, 0);
        }

        rigidbody2D.velocity = vel;*/

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0.1f, 0);

            if (!isHit)
            animator.Play("WalkingUp");
        }
    
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(0.1f, 0, 0);

            if (!isHit)
                animator.Play("WalkingRight");
            
        }

        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-0.1f, 0, 0);

            if (!isHit)
            animator.Play("WalkingLeft");
        }


        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.1f, 0);

            if (!isHit)
            animator.Play("WalkingForward");
        }
        else
        {
            if (!isHit)
            animator.Play("Idle");
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
            //isHit = true;
			PlayerScore.ChangeScore(-5);
			flashScreen = true;      
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
            //isHit = true;
            PlayerScore.ChangeScore(-2);
			flashScreen = true;
        }
    }

    void AnimatePlayer()
    {


    }

    public static void respawnPlayer()
    {
        respawn = true;
    }

	void OnGUI () {

		if (flashScreen) {
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), hitScreen, ScaleMode.StretchToFill);
			StartCoroutine(FlashWait());
		}
	}

	IEnumerator FlashWait () {

		yield return new WaitForSeconds(0.2f);
		flashScreen = false;

	}

}
