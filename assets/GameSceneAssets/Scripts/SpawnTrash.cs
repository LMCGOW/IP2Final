using UnityEngine;
using System.Collections;

public class SpawnTrash : MonoBehaviour {

    public float probability = 10f;

    static int trashCount;
    int maxTrashCount = 20;

    public GameObject trash;

	// Use this for initialization
	void Start () {

        trashCount = 0;

	}
	
	// Update is called once per frame
	void Update () {

        if (RandomNumber.GenerateRandomNumber(0, 100000) < 5 && trashCount < maxTrashCount)
        {
            Instantiate(trash, this.transform.position, new Quaternion(0, 0, 0, 0));
            trashCount++;
        }

	}

    public static void RemoveTrash()
    {
        trashCount--;
    }





}
