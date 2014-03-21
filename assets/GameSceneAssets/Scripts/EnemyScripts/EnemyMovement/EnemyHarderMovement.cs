using UnityEngine;
using System.Collections;

public class EnemyHarderMovement : MonoBehaviour {


    GameObject player;

    public bool checkLeft;
    public bool checkRight;
    public bool checkUp;
    public bool checkDown;

    bool checkForPlayerRight;
    bool checkForPlayerLeft;
    bool checkForPlayerUp;
    bool checkForPlayerDown;

    public bool checkForRecyclingPlant;

    public bool moveUp;
    public bool moveDown;
    public bool moveRight;
    public bool moveLeft;

    bool chasePlayer = false;

    public string previousMovement;

    int random1;
    int random2;

    float enemyWalkingSpeed = 2.4f;

    float timer = 2f;

    // Use this for initialization
    void Start()
    {

        random1 = RandomNumber.GenerateRandomNumber(0, 20);

        if (random1 < 5)
            moveUp = true;

        if (random1 >= 5 && random1 <= 10)
            moveDown = true;

        if (random1 >= 10 && random1 <= 15)
            moveRight = true;

        if (random1 >= 15 && random1 <= 20)
            moveLeft = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (!chasePlayer)
        {
            CheckDirections();
            ChangeDirections();
            RandomlyChangeDirection();
            MoveEnemy();
            //CheckForPlayer();
        }

        if (chasePlayer)
            ChasePlayer();

    }

    void CheckDirections()
    {

        checkRight = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("Wall"));
        checkLeft = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("Wall"));
        checkUp = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y + 0.3f), 1 << LayerMask.NameToLayer("Wall"));
        checkDown = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y - 0.3f), 1 << LayerMask.NameToLayer("Wall"));

        checkForPlayerRight = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.6f, this.transform.position.y), 1 << LayerMask.NameToLayer("Player"));
        checkForPlayerLeft = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.6f, this.transform.position.y), 1 << LayerMask.NameToLayer("Player"));
        checkForPlayerUp = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y + 0.6f), 1 << LayerMask.NameToLayer("Player"));
        checkForPlayerDown = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y - 0.6f), 1 << LayerMask.NameToLayer("Player")); ;


        checkForRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.3f, this.transform.position.y + 0.3f), 1 << LayerMask.NameToLayer("RecyclingPlant"));

        /* Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.6f, this.transform.position.y));
         Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.6f, this.transform.position.y));
         Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y + 0.6f));
         Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y - 0.6f));
         */
    }

    void ChangeDirections()
    {



        if (checkDown && moveDown)
        {
            random2 = RandomNumber.GenerateRandomNumber(0, 15);

            if (random2 <= 5)
            {
                moveUp = true;
                moveLeft = false;
                moveDown = false;
                moveRight = false;
            }
            else if (random2 > 5 && random2 <= 10)
            {
                moveLeft = true;
                moveUp = false;
                moveDown = false;
                moveRight = false;
            }
            else
            {
                moveRight = true;
                moveLeft = false;
                moveDown = false;
                moveUp = false;
            }
        }

        if (checkUp && moveUp)
        {
            random2 = RandomNumber.GenerateRandomNumber(0, 15);

            if (random2 <= 5)
            {
                moveDown = true;
                moveLeft = false;
                moveUp = false;
                moveRight = false;
            }

            else if (random2 > 5 && random2 <= 10)
            {
                moveLeft = true;
                moveUp = false;
                moveDown = false;
                moveRight = false;
            }

            else
            {
                moveRight = true;
                moveLeft = false;
                moveDown = false;
                moveUp = false;
            }
        }

        if ((checkRight && moveRight))
        {
            random2 = RandomNumber.GenerateRandomNumber(0, 15);

            if (random2 <= 5)
            {
                moveUp = true;
                moveLeft = false;
                moveDown = false;
                moveRight = false;
            }

            else if (random2 > 5 && random2 <= 10)
            {
                moveLeft = true;
                moveUp = false;
                moveDown = false;
                moveRight = false;
            }

            else
            {
                moveDown = true;
                moveLeft = false;
                moveUp = false;
                moveRight = false;
            }

        }

        if ((checkLeft && moveLeft) || (checkForRecyclingPlant && moveLeft))
        {
            random2 = RandomNumber.GenerateRandomNumber(0, 15);

            if (random2 <= 5)
            {
                moveUp = true;
                moveLeft = false;
                moveDown = false;
                moveRight = false;
            }

            else if (random2 > 5 && random2 <= 10)
            {
                moveDown = true;
                moveLeft = false;
                moveUp = false;
                moveRight = false;
            }

            else
            {
                moveRight = true;
                moveLeft = false;
                moveDown = false;
                moveUp = false;
            }

        }


    }

    void MoveEnemy()
    {
        if (moveUp)
            rigidbody2D.velocity = new Vector2(0, enemyWalkingSpeed);
        else if (moveDown)
            rigidbody2D.velocity = new Vector2(0, -enemyWalkingSpeed);
        else if (moveRight)
            rigidbody2D.velocity = new Vector2(enemyWalkingSpeed, 0);
        else if (moveLeft)
            rigidbody2D.velocity = new Vector2(-enemyWalkingSpeed, 0);
    }

    //Will check if the enemy has seen the player
    void CheckForPlayer()
    {

        if (checkForPlayerUp || checkForPlayerLeft || checkForPlayerRight || checkForPlayerDown)
        {

            chasePlayer = true;

        }

    }

    //Enemy will chase the player if it can see him
    void ChasePlayer()
    {
        player = GameObject.Find("Player");

        float chaseTimer = 5f;

        chaseTimer -= Time.deltaTime;

        if (chaseTimer <= 0)
        {
            chasePlayer = false;
        }

        if (this.transform.position.x < player.transform.position.x)
            this.transform.position += new Vector3(enemyWalkingSpeed, 0, 0);

        else if (this.transform.position.x > player.transform.position.x)
            this.transform.position -= new Vector3(enemyWalkingSpeed, 0, 0);

        if (this.transform.position.y < player.transform.position.y)
            this.transform.position += new Vector3(0, enemyWalkingSpeed, 0);

        else if (this.transform.position.y > player.transform.position.y)
            this.transform.position -= new Vector3(0, enemyWalkingSpeed, 0);
    }

    void RandomlyChangeDirection()
    {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            float randomNumber = RandomNumber.GenerateRandomNumber(0, 75);



            if (checkRight)
            {

                if (randomNumber < 25)
                {
                    moveRight = false;
                    moveLeft = true;
                    moveDown = false;
                    moveUp = false;
                }
                else if (randomNumber > 25 && randomNumber < 50)
                {
                    moveRight = false;
                    moveLeft = false;
                    moveDown = true;
                    moveUp = false;
                }
                else
                {
                    moveRight = false;
                    moveLeft = false;
                    moveDown = false;
                    moveUp = true;

                }


            }


            else if (checkUp)
            {

                if (randomNumber < 25)
                {
                    moveRight = false;
                    moveLeft = true;
                    moveDown = false;
                    moveUp = false;
                }
                else if (randomNumber > 25 && randomNumber < 50)
                {
                    moveRight = false;
                    moveLeft = false;
                    moveDown = true;
                    moveUp = false;
                }
                else
                {
                    moveRight = true;
                    moveLeft = false;
                    moveDown = false;
                    moveUp = false;

                }


            }


            else if (checkLeft)
            {

                if (randomNumber < 25)
                {
                    moveRight = true;
                    moveLeft = false;
                    moveDown = false;
                    moveUp = false;
                }
                else if (randomNumber > 25 && randomNumber < 50)
                {
                    moveRight = false;
                    moveLeft = false;
                    moveDown = true;
                    moveUp = false;
                }
                else
                {
                    moveRight = false;
                    moveLeft = false;
                    moveDown = false;
                    moveUp = true;

                }


            }


            else
            {

                if (randomNumber < 25)
                {
                    moveRight = false;
                    moveLeft = true;
                    moveDown = false;
                    moveUp = false;
                }
                else if (randomNumber > 25 && randomNumber < 50)
                {
                    moveRight = false;
                    moveLeft = false;
                    moveDown = false;
                    moveUp = true;
                }
                else
                {
                    moveRight = false;
                    moveLeft = false;
                    moveDown = false;
                    moveUp = true;

                }


            }

            timer = 2f;

        }
    }

}
