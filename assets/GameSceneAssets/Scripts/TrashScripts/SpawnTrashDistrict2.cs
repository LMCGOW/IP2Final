using UnityEngine;
using System.Collections;

public class SpawnTrashDistrict2 : MonoBehaviour {


    public GameObject[] trashList = new GameObject[5];

    int maxTrashCount = 15;
    int trashCount = 0;

    int randomNumber;
    int randomTrashIndex;

    // Use this for initialization
    void Start()
    {

        trashCount = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerScore.SafeScore >= 20 && PlayerScore.SafeScore < 40)
        {

            randomTrashIndex = RandomNumber.GenerateRandomNumber(0, 5);

            if (RandomNumber.GenerateRandomNumber(0, 100000) < 5 && trashCount < maxTrashCount)
            {
                Instantiate(trashList[randomTrashIndex], this.transform.position, new Quaternion(0, 0, 0, 0));
                trashCount++;

            }
        }

    }
}
