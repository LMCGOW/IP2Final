using UnityEngine;
using System.Collections;

public class MG_ControlSpray : MonoBehaviour {

	public AudioClip Siren;
	public bool sirenPlay = false;



    float moveSpeed = 3f;
    public static float sprayRemaining = 100;

	// Use this for initialization
	void Start () {

     
        this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);


	}
	
	// Update is called once per frame
	void Update () {

       Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

       if (Input.GetMouseButton(0))
       {
           RemoveSpray();
       }
	   else if(Input.GetMouseButtonUp(0))
		{
			GameObject.Find("_MiniGameManager").GetComponent<MG_SoundScript>().sprayPlay = false;
			GameObject.Find("_MiniGameManager").GetComponent<MG_SoundScript>().sprayEmptyPlay = false;
			GameObject.Find("BugSpray").audio.loop = false;
		}

       if (sprayRemaining <= 0)
           sprayRemaining = 0;

       if (sprayRemaining >= 100)
           sprayRemaining = 100;

	}

    /// <summary>
    /// When called, this will begin to deplete the spray can
    /// </summary>
    public static void RemoveSpray()
    {

        sprayRemaining -= 0.5f;
		 
		if(sprayRemaining > 0)
		{
			GameObject.Find("_MiniGameManager").GetComponent<MG_SoundScript>().sprayPlay = true;
		}
		else
		{
			GameObject.Find("_MiniGameManager").GetComponent<MG_SoundScript>().sprayEmptyPlay = true;
		}

    }

    public static float GetSprayRemaining()
    {
        return sprayRemaining;
    }

    public static void AddSpray(float increment)
    {

        sprayRemaining += increment;

    }

    

   
}
