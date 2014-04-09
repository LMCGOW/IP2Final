using UnityEngine;
using System.Collections;

public class VisionSystem : MonoBehaviour {

    public bool atRecyclingPlant = false;
	
	public Texture2D pressSpaceImageTexture;

	//Draws items on GUI layer
	void OnGUI () {

		if (atRecyclingPlant && PlayerScore.Score>=5)
			GUI.DrawTexture(new Rect(Screen.width/2 - 91.5f, Screen.height/2 - 80, 183, 40), pressSpaceImageTexture, ScaleMode.StretchToFill, true, 0);
	}
	
	// Update is called once per frame
	void Update () {

        CheckIfAtRecyclingPlant();
	}


	void CheckIfAtRecyclingPlant()
	{
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("RecyclingPlant"));
		
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
                //PlayerMovement.ResetSpeed();
				timerHandlerScript.timerSaveMinutes = Timer.timerMinutes;
				timerHandlerScript.timerSaveSeconds = Timer.timerSeconds;
				timerHandlerScript.timeSaved = true;
                PlayerMovement.playerSpawn = this.transform.position;
				Application.LoadLevel(2);
			}
	
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.3f, this.transform.position.y));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("RecyclingPlant"));
			
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
				//PlayerMovement.ResetSpeed();
				timerHandlerScript.timerSaveMinutes = Timer.timerMinutes;
				timerHandlerScript.timerSaveSeconds = Timer.timerSeconds;
				timerHandlerScript.timeSaved = true;
                PlayerMovement.playerSpawn = this.transform.position;
				Application.LoadLevel(2);
			}
	
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y - 0.3f));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y - 0.3f), 1 << LayerMask.NameToLayer("RecyclingPlant"));
			
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
				//PlayerMovement.ResetSpeed();
				timerHandlerScript.timerSaveMinutes = Timer.timerMinutes;
				timerHandlerScript.timerSaveSeconds = Timer.timerSeconds;
				timerHandlerScript.timeSaved = true;
                PlayerMovement.playerSpawn = this.transform.position;
				Application.LoadLevel(2);
			}
	
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y + 0.3f));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y + 0.3f), 1 << LayerMask.NameToLayer("RecyclingPlant"));
			
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
				//PlayerMovement.ResetSpeed();
				timerHandlerScript.timerSaveMinutes = Timer.timerMinutes;
				timerHandlerScript.timerSaveSeconds = Timer.timerSeconds;
				timerHandlerScript.timeSaved = true;
                PlayerMovement.playerSpawn = this.transform.position;
				Application.LoadLevel(2);
                
			}
	}


    /*void CheckIfAtRecyclingPlant()
    {
        Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y));
        atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("RecyclingPlant"));

        if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score > 5)
        {
			//PlayerMovement.ResetSpeed();
            PlayerScore.ChangeSafeScore();
            Application.LoadLevel(1);
        }

    }*/
}
