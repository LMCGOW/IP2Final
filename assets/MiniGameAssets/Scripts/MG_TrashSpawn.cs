using UnityEngine;
using System.Collections;

public class MG_TrashSpawn : MonoBehaviour {

    public GameObject trash;

	//The amount of trash to use this level
	int amountOfTrash;

    static int trashLeft;

    float timer = 0f;

	// Use this for initialization
	void Start () {

        amountOfTrash = PlayerScore.Score;
        //amountOfTrash = 100;
        trashLeft = amountOfTrash;

        Debug.Log(PlayerScore.SafeScore);

        AddTrash();

	}
	
	// Update is called once per frame
	void Update () {

		CheckForNewTrash();

	}

    void CheckForNewTrash()
    {
        timer += Time.deltaTime;

		if (timer >= 3 && amountOfTrash > 0)
        {
            AddTrash();
            timer = 0;
        }

        Debug.Log("Trash left: " + trashLeft);

        if (trashLeft == 0)
        {
            PlayerMovement.respawnPlayer();
            Application.LoadLevel(1);
        }
    }

    void AddTrash()
    {
        Instantiate(trash, this.transform.position, new Quaternion(0, 0, 0, 0));
		amountOfTrash--;
    }

    public static void ChangeTrashLeft()
    {
        trashLeft--;
    }
}
