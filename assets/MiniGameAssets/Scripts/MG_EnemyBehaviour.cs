using UnityEngine;
using System.Collections;

public class MG_EnemyBehaviour : MonoBehaviour {

    public GameObject background;
	public GameObject[] trashOnScreen;
    public GameObject healthReduction;

	public GameObject conveyorEntrance;

    //The health of the enemy
    int health = 100;

	//The number that will be generated to pick a random gameobject from the trashOnScreen array
	int trashFocusIndex;
	//Will store the trash that the game object will follow
	public GameObject trashFocus;

	//This will be true if the enemy has already located a piece of trash to follow
	bool foundTrash = false;

	//Will be true if the enemy has not yet passed the conveyor belt
	bool hasNotPassedConveyor = true;

    public float speed = 0.03f;

	// Use this for initialization
	void Start () {
	
        

	}
	
	// Update is called once per frame
	void Update () {

        MoveEnemy();
		FindTrash ();
		CheckIfPassedConveyor ();

		//Will only head towards trash if that particular trash exists
		if (trashFocus != null) {
						HeadTowardTrash ();
				}

        if (health <= 0)
            Destroy(gameObject);

        
	}

	/// <summary>
	/// Checks if passed conveyor.
	/// </summary>
	void CheckIfPassedConveyor(){

		if (this.transform.position.y > conveyorEntrance.transform.position.y) {
			hasNotPassedConveyor = false;
				}

		}

	/// <summary>
	/// Finds the trash.
	/// </summary>
	void FindTrash(){

		if (!foundTrash) {

			//Generates the array of trash
		    trashOnScreen = GameObject.FindGameObjectsWithTag ("MG_Trash");

			//Generates a random index for accessing that array
			trashFocusIndex = RandomNumber.GenerateRandomNumber (0, trashOnScreen.Length);


            if (trashOnScreen[trashFocusIndex].transform.position.x >= this.transform.position.x - 2 && trashOnScreen[trashFocusIndex].transform.position.x <= this.transform.position.x + 2)
            {
                if (trashOnScreen.Length > 0)
                {
                    //Sets the trashFocus object to that element at that random index
                    trashFocus = trashOnScreen[trashFocusIndex];
                    foundTrash = true;
                }
                else
                {
                    foundTrash = false;
                }


            }
            else
            {
                foundTrash = false;
            }
                

		}

	}

	/// <summary>
	/// Causes the enemy to head toward the trash.
	/// </summary>
	void HeadTowardTrash(){

		//Will only head towards the trash if it has no already passed the conveyor belt
		if (hasNotPassedConveyor && trashFocus != null) {

						Vector3 trashPosition = trashFocus.transform.position;

                      
                            if (this.transform.position.x > trashPosition.x)
                            {

                                this.transform.position -= new Vector3(speed, 0, 0);
                                this.transform.position -= new Vector3(0, 0.005f, 0);

                            }
                            else if (this.transform.position.x < trashPosition.x)
                            {

                                this.transform.position += new Vector3(speed, 0, 0);
                                this.transform.position -= new Vector3(0, 0.005f, 0);

                            }

           

                            if (this.transform.position.x > (trashPosition.x - 0.1f) && this.transform.position.x < (trashPosition.x + 0.1f))
                            {

                                if (this.transform.position.y > trashPosition.y)
                                {

                                    this.transform.position -= new Vector3(0, speed, 0);

                                }

                            }
		

				} else {

			this.transform.position -= new Vector3(0, speed, 0);

				}

	}

    void MoveEnemy()
    {

        HeadTowardTrash();

    }

    void OnMouseDown()
    {
       
    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.collider.tag == "MG_BugSpray" && Input.GetMouseButton(0) && MG_ControlSpray.GetSprayRemaining() > 0.0f)
        {
            health -= 50;
            DisplayHealthReduction();
        }
    }

    /// <summary>
    /// Displays a graphic when health is reduced
    /// </summary>
    void DisplayHealthReduction()
    {

      Instantiate(healthReduction, new Vector3(this.transform.position.x + 0.4f, this.transform.position.y + 0.4f, 0), Quaternion.identity);	

    }

   
}
