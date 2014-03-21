using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {

    static int playerScore = 0;
    static int safePlayerScore = 20;

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

	}



    void OnGUI()
    {

        GUI.Box(new Rect(10, 10, 150, 20), "Trash Carried: " + playerScore);
        GUI.Box(new Rect(10, 40, 150, 20), "Recycled Trash: " + safePlayerScore);

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
