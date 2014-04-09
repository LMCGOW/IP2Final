using UnityEngine;
using System.Collections;

public class ArrowPointer : MonoBehaviour {
	
	public Camera cam;
	public GameObject target;

	public GameObject arrow;
	
	private Vector3 targetPos;
	private Vector3 screenMid;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (PlayerScore.Score >= 5) 
		{
			gameObject.renderer.enabled = true;
		}
		else
		{
			gameObject.renderer.enabled = false;
		}

		Indicator ();

	}

	void Indicator () {

		if (PlayerScore.Score >= 5) {
			// Find target's position on screen and save as Vector3
			targetPos = cam.WorldToScreenPoint (target.transform.position);
			// Find middle of screen as Vector3
			screenMid = new Vector3 (Screen.width/2, Screen.height/2, 0);
			
			targetPos -= screenMid;
			
			float angle = Mathf.Atan2 (targetPos.y, targetPos.x);
			angle -= 90 * Mathf.Deg2Rad;
			
			float cos = Mathf.Cos (angle);
			float sin = Mathf.Sin (angle);
			
			targetPos = screenMid + new Vector3 (sin*150, cos*150, 0);
			
			float 	m = cos / sin;	
			
			Vector3 screenBounds = screenMid * 0.9f;
			
			if (cos > 0)
			{
				targetPos = new Vector3 (screenBounds.y/m, screenBounds.y, 0);
			}
			else
			{
				targetPos = new Vector3 (-screenBounds.y/m, -screenBounds.y, 0);
			}
			
			if (targetPos.x > screenBounds.x)
			{
				targetPos = new Vector3 (screenBounds.x, screenBounds.x * m, 0);
			}
			else if (targetPos.x < screenBounds.x)
			{
				targetPos = new Vector3 (-screenBounds.x, -screenBounds.x * m, 0);
			}
			
			targetPos += screenMid;
			
			arrow.transform.localRotation = Quaternion.Euler(0, 0, angle*Mathf.Rad2Deg);
		}
	}
}
