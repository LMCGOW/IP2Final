using UnityEngine;
using System.Collections;

public class timerHandlerScript : MonoBehaviour {

	public static float timerSaveMinutes;
	public static float timerSaveSeconds;

	public static bool timeSaved = false;

	// Use this for initialization
	void Start () {
	
		DontDestroyOnLoad(this);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
