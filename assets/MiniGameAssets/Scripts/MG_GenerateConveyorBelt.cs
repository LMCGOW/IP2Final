using UnityEngine;
using System.Collections;

public class MG_GenerateConveyorBelt : MonoBehaviour {

    public static float backgroundStart;

    //List of conveyor belt objects
    public GameObject[] conveyorParts = new GameObject[4];
    /*
     * 0 = conveyor start
     * 1 = conveyor mid
     * 2 = conveyor corner
     * 3 = conveyor end
     * */

    //Background game object
    public GameObject background;

    //The direction that the conveyor belt is being generated in
    string direction = "right";

    //The starting position, current position, and ending position of the conveyor belt generation
    Vector3 startingPosition = new Vector3();
    Vector3 currentPosition = new Vector3();
    Vector3 endingPosition = new Vector3();

    //The number of tiles that have been generated in a specific direction (will always be one as it takes into account the initial starting tile)
    int numberOfTilesInDirection = 1;


	// Use this for initialization
	void Start () {

        backgroundStart = background.transform.position.x - background.renderer.bounds.size.x / 2;
        startingPosition.y = background.transform.position.y;

        //Sets the starting position to the middle of the left hand side of the background image
        startingPosition.x = background.transform.position.x - (background.renderer.bounds.size.x / 2 -conveyorParts[0].renderer.bounds.size.x / 2);
        startingPosition.y = background.transform.position.y;

        //Sets the ending position to the middle of the right hand side of the background image
        endingPosition.x = background.transform.position.x * 2;
        endingPosition.y = background.transform.position.y * 2;

        GenerateTemporaryConveyorBelt();
        //GenerateConveyorBelt();

        Screen.showCursor = false;

	}

    /// <summary>
    /// This method will generate the conveyor belt in the correct fashion
    /// </summary>
    void GenerateConveyorBelt()
    {
        //Instantiates the starting tile
        Instantiate(conveyorParts[0], startingPosition, new Quaternion(0, 0, 0, 0));

        //Sets the current position to the end of the starting position
        currentPosition = new Vector3(startingPosition.x + conveyorParts[0].renderer.bounds.size.x, startingPosition.y, 0);

        //Checks which direction the generation is going in and begins to generate in that direction
        switch(direction){
          
            case "up":
                MoveUp();
                break;
            case "right":
                MoveRight();
                break;
            case "left":
                MoveLeft();
                break;
            case "down":
                MoveDown();
                break;

        }


    }

    /// <summary>
    /// Will move the conveyor belt left during generation.
    /// </summary>
    void MoveUp()
    {
        //Will generate the path
        for (int y = 0; y < 4; y++)
        {
            //Draws the tiles are the correct position
            Instantiate(conveyorParts[1], new Vector3(currentPosition.x, conveyorParts[1].renderer.bounds.size.y * numberOfTilesInDirection, 0), new Quaternion(0, 0, 90, 0));
            numberOfTilesInDirection++;
        }
    }

    /// <summary>
    /// Will move the conveyor belt down during generation.
    /// </summary>
    void MoveDown()
    {

    }

    /// <summary>
    /// Will move the conveyor belt right during generation.
    /// </summary>
    void MoveRight()
    {
        //Will generate the path
        for (int x = 0; x < 4; x++)
        {
            //Draws the tiles are the correct position
            Instantiate(conveyorParts[1], new Vector3(conveyorParts[1].renderer.bounds.size.x * numberOfTilesInDirection, currentPosition.y, 0), new Quaternion(0, 0, 90, 0));
            numberOfTilesInDirection++;
        }
    }

    /// <summary>
    /// Will move the conveyor belt left during generation.
    /// </summary>
    void MoveLeft()
    {

    }

    void Turn()
    {


    }

    /// <summary>
    /// Generates a temporary conveyor belt
    /// </summary>
    void GenerateTemporaryConveyorBelt()
    {
        //Instantiates the starting tile
        Instantiate(conveyorParts[0], startingPosition, new Quaternion(0, 0, 0, 0));

        //Sets the current position to the end of the starting position
        currentPosition = new Vector3(startingPosition.x + conveyorParts[0].renderer.bounds.size.x, startingPosition.y, 0);

        for (int x = (int)currentPosition.x; x < 8; x++)
        {
            Instantiate(conveyorParts[1], new Vector3((currentPosition.x - conveyorParts[1].renderer.bounds.size.x) + (numberOfTilesInDirection * conveyorParts[1].renderer.bounds.size.x), currentPosition.y, 0), new Quaternion(0, 0, 0, 0));
            numberOfTilesInDirection++;
        }

        Instantiate(conveyorParts[3], new Vector3(8.753906f, currentPosition.y, 0), new Quaternion(0, 0, 0, 0));

    }

    // Update is called once per frame
    void Update()
    {

	}
}
