using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 20, 250, 40), "You managed to recycle " + PlayerScore.SafeScore + " trash.");
    }
}
