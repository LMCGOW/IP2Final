using UnityEngine;
using System.Collections;

public class SpawnTrash : MonoBehaviour {

    public float probability = 10f;

    static int trashCount;
    int maxTrashCount = 20;

    int randomTrashIndex;

    public GameObject[] trashList = new GameObject[3];

	// Use this for initialization
	void Start () {

        trashCount = 0;

	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerScore.SafeScore <= 20)
        {
            randomTrashIndex = RandomNumber.GenerateRandomNumber(0, 3);

            if (RandomNumber.GenerateRandomNumber(0, 100000) < 5 && trashCount < maxTrashCount)
            {
                Instantiate(trashList[randomTrashIndex], this.transform.position, new Quaternion(0, 0, 0, 0));
                trashCount++;
            }
        }
        

	}

    public static void RemoveTrash()
    {
        trashCount--;
    }





}
