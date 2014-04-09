using UnityEngine;
using System.Collections;

public class MG_ShowScore : MonoBehaviour {

    static int score= 0; 

	public GUIStyle mg_HUD;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void AddScore(int addition)
    {
        score += addition;
    }

	void OnGUI ()
	{
		GUI.Box(new Rect(10, Screen.height - 60, 150, 20), "Trash Left: " + MG_TrashSpawn.Score, mg_HUD);
		GUI.Box(new Rect(10, Screen.height - 30, 150, 20), "Trash Recycled: " + score, mg_HUD);
		
	}
  
}
