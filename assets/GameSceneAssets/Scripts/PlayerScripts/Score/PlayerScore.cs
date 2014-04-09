using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {

    static int playerScore = 0;
    static int safePlayerScore = 0;

	public AudioClip[] trashPickup;

	public bool play = false;
	
	public GUIStyle counterStyle;

	public static int Score{

		get { return playerScore; }

	}

	public static int SafeScore{

		get{ return safePlayerScore; }

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (playerScore < 0)
            playerScore = 0;

		PlaySound();

	}

	void PlaySound () {

		if(play) 
		{
			audio.clip = trashPickup[Random.Range(0, trashPickup.Length)];
			audio.Play();
			play = false;
		}
	}

    void OnGUI()
    {

		GUI.Box(new Rect(10, 10, 150, 20), "Trash Carried: " + playerScore, counterStyle);
		GUI.Box(new Rect(10, 40, 150, 20), "Recycled Trash: " + safePlayerScore, counterStyle);

    }

    /// <summary>
    /// Change the score.
    /// </summary>
    /// <param name="delta">the amount to change it by</param>
    public static void ChangeScore(int delta)
    {
        playerScore += delta;
    }

    public static void ChangeSafeScore(int score)
    {
        safePlayerScore += score;
        playerScore = 0;
    }
}
