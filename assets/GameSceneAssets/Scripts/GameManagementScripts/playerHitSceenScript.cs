using UnityEngine;
using System.Collections;

public class playerHitSceenScript : MonoBehaviour {

	public Texture2D hitScreen;

	// Use this for initialization
	void Start () {

		StartCoroutine(WaitAndKill());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGui () {

		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), hitScreen, ScaleMode.StretchToFill);

	}

	IEnumerator WaitAndKill () {

		yield return new WaitForSeconds(1F);
		Destroy(gameObject);

	}
}
