using UnityEngine;
using System.Collections;

public class MG_SoundScript : MonoBehaviour {

	public AudioClip Siren;
	public bool sirenPlay = false;

	public AudioClip Recycle;
	public bool recyclePlay = false;

	public AudioClip Spray;
	public bool sprayPlay = false;

	public AudioClip SprayEmpty;
	public bool sprayEmptyPlay = false;

	// Update is called once per frame
	void Update () {

		PlayEffects();
	
	}

	void PlayEffects () {

		if (sirenPlay)
		{
			audio.clip = Siren;
			audio.Play();
			sirenPlay = false;
		}

		if (recyclePlay)
		{
			audio.clip = Recycle;
			audio.Play();
			recyclePlay = false;
		}

		if (sprayPlay && !GameObject.Find("BugSpray").audio.isPlaying)
		{	
			GameObject.Find("BugSpray").audio.clip = Spray;
			GameObject.Find("BugSpray").audio.loop = true;
			GameObject.Find("BugSpray").audio.Play();
		}


		if (sprayEmptyPlay && !GameObject.Find("BugSpray").audio.isPlaying)
		{
			GameObject.Find("BugSpray").audio.clip = SprayEmpty;
			GameObject.Find("BugSpray").audio.loop = true;
			GameObject.Find("BugSpray").audio.Play();
		}

	}
}
