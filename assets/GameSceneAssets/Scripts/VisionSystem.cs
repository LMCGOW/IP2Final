using UnityEngine;
using System.Collections;

public class VisionSystem : MonoBehaviour {

    public bool atRecyclingPlant = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        CheckIfAtRecyclingPlant();
        
	}


	void CheckIfAtRecyclingPlant()
	{
		if (Input.GetAxis("Horizontal") < 0) 
		{
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("RecyclingPlant"));
		
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
				//PlayerMovement.ResetSpeed();
				PlayerScore.ChangeSafeScore();
				Application.LoadLevel(2);
			}
		}

		if (Input.GetAxis("Horizontal") > 0) 
		{
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.3f, this.transform.position.y));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x + 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("RecyclingPlant"));
			
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
				//PlayerMovement.ResetSpeed();
				PlayerScore.ChangeSafeScore();
				Application.LoadLevel(2);
			}
		}

		if (Input.GetAxis("Vertical") < 0) 
		{
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y - 0.3f));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y - 0.3f), 1 << LayerMask.NameToLayer("RecyclingPlant"));
			
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
				//PlayerMovement.ResetSpeed();
				PlayerScore.ChangeSafeScore();
				Application.LoadLevel(2);
			}
		}

		if (Input.GetAxis("Vertical") > 0) 
		{
			Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y + 0.3f));
			atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x, this.transform.position.y + 0.3f), 1 << LayerMask.NameToLayer("RecyclingPlant"));
			
			if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
			{
				//PlayerMovement.ResetSpeed();
				PlayerScore.ChangeSafeScore();
				Application.LoadLevel(2);
			}
		}
		
	}


    /*void CheckIfAtRecyclingPlant()
    {
        Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y));
        atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("RecyclingPlant"));

        if (Input.GetKey(KeyCode.Space) && atRecyclingPlant && PlayerScore.Score >= 5)
        {
			//PlayerMovement.ResetSpeed();
            PlayerScore.ChangeSafeScore();
            Application.LoadLevel(2);
        }

    }*/
}
