using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	public GUIStyle endScene;
	public GUIStyle endMess;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 340, Screen.height / 2 - 20, 250, 40), "You managed to recycle " + PlayerScore.SafeScore + " trash.", endMess);
    
		if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 60, 180, 40), "Main Menu", endScene))
		{
			Application.LoadLevel(0);
		}

	}
}
