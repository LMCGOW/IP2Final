using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	//public Texture backgroundTexture;
	public GameObject instructionsTexture;

	public int buttonWidth;
	public int buttonHeigth;
	public int buttonChangePos;

	public GUIStyle uiStyle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnGUI () {

	//	GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture, ScaleMode.StretchToFill, true, 0);

		if (instructionsTexture.activeSelf == false) { 

		if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,Screen.height/2-buttonHeigth/2,buttonWidth,buttonHeigth), "Play", uiStyle)) {
			Application.LoadLevel(1);
		}

			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,(Screen.height/2-buttonHeigth/2) + buttonChangePos,buttonWidth,buttonHeigth), "Instructions", uiStyle)) {
				instructionsTexture.SetActive(true);
		}
		
			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,(Screen.height/2-buttonHeigth/2) + buttonChangePos*2,buttonWidth,buttonHeigth), "Quit", uiStyle)) {
			Application.Quit();
		}

		}
	}
}
