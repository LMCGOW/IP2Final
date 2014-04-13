using UnityEngine;
using System.Collections;

public class SpawnEnemyDistrict2 : MonoBehaviour {
    
    static int enemyCount = 0;
    public static int maxEnemyCount = 8;

    public GameObject enemyHarder;

    // Use this for initialization
    void Start()
    {

        enemyCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScore.SafeScore >= 15 /*20 && PlayerScore.SafeScore < 40*/)
        {
            SpawnEnemies();
        }

    }

    public void SpawnEnemies()
    {
        if (RandomNumber.GenerateRandomNumber(0, 20000) < 2 && enemyCount < maxEnemyCount)
        {
            Instantiate(enemyHarder, this.transform.position, new Quaternion(0, 0, 0, 0));
            enemyCount++;
        }
    }
}
