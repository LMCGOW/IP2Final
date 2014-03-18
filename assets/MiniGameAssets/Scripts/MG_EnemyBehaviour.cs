using UnityEngine;
using System.Collections;

public class MG_EnemyBehaviour : MonoBehaviour {

    public GameObject background;
	public GameObject[] trashOnScreen;

	public GameObject conveyorEntrance;

	//The number that will be generated to pick a random gameobject from the trashOnScreen array
	int trashFocusIndex;
	//Will store the trash that the game object will follow
	public GameObject trashFocus;

	//This will be true if the enemy has already located a piece of trash to follow
	bool foundTrash = false;

	//Will be true if the enemy has not yet passed the conveyor belt
	bool hasNotPassedConveyor = true;

    public float speed = 0.02f;

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

			if(trashOnScreen.Length > 0){
			//Sets the trashFocus object to that element at that random index
			trashFocus = trashOnScreen [trashFocusIndex];

			//Set foundTrash = true
			foundTrash = true;
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

						if (this.transform.position.y > trashPosition.y) {
	
								this.transform.position -= new Vector3 (0, speed, 0);

						}

						if (this.transform.position.x > trashPosition.x) {

								this.transform.position -= new Vector3 (speed, 0, 0);
	
						} else if (this.transform.position.x < trashPosition.x) {

								this.transform.position += new Vector3 (speed, 0, 0);

						}

					
			RotateToFace();
		

				} else {

			this.transform.position -= new Vector3(0, speed, 0);

				}

	}

    void MoveEnemy()
    {

        this.transform.position -= new Vector3(0, speed, 0);

    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

	/// <summary>
	/// Rotates the enemy to face the trash.
	/// </summary>
	void RotateToFace(){

		var newRotation = Quaternion.LookRotation(transform.position - trashFocus.transform.position, Vector3.forward);
		
		newRotation.x = 0.0f;
		
		newRotation.y = 0.0f;
		
		transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8);
	}
}
