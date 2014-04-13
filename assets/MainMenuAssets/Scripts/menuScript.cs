using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Texture backgroundTexture;
	public Texture instructionsTexture;

	public bool instructionsTextureBool;

	public int buttonWidth;
	public int buttonHeigth;
	public int buttonChangePos;

	public AudioClip buttonClick;

	public GUIStyle uiStyle;
	public GUIStyle titleStyle;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnGUI () {

	GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture, ScaleMode.StretchToFill, true, 0);

		GUI.Box(new Rect(Screen.width/2 - 250, 100, 500, 150), "Operation Litter Bug", titleStyle);

		if (instructionsTextureBool == false) { 

			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,Screen.height/2-buttonHeigth/2,buttonWidth,buttonHeigth), "Play", uiStyle)) {
				Application.LoadLevel(1);
				audio.PlayOneShot(buttonClick);
			}

			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,(Screen.height/2-buttonHeigth/2) + buttonChangePos,buttonWidth,buttonHeigth), "Instructions", uiStyle)) {
				instructionsTextureBool = true;
				audio.PlayOneShot(buttonClick);
			}
		
			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,(Screen.height/2-buttonHeigth/2) + buttonChangePos*2,buttonWidth,buttonHeigth), "Quit", uiStyle)) {
				Application.Quit();
				audio.PlayOneShot(buttonClick);
			}

		}
		else 
		{
			GUI.DrawTexture(new Rect(Screen.width/2 - 320, Screen.height/2 - 190, 640, 400), instructionsTexture);

			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,(Screen.height/2-buttonHeigth/2) + buttonChangePos*2,buttonWidth,buttonHeigth), "Close", uiStyle)) {
				instructionsTextureBool = false;
				audio.PlayOneShot(buttonClick);
			}
		}
	}
}
