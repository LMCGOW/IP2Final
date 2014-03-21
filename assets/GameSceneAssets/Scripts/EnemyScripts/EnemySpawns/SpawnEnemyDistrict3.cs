using UnityEngine;
using System.Collections;

public class SpawnEnemyDistrict3 : MonoBehaviour {

    static int enemyCount = 0;
    public static int maxEnemyCount = 70;

    public GameObject enemyHarder;
    public GameObject enemy;

    // Use this for initialization
    void Start()
    {

        enemyCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScore.SafeScore >= 40)
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

        if (RandomNumber.GenerateRandomNumber(0, 10000) < 2 && enemyCount < maxEnemyCount)
        {
            Instantiate(enemy, this.transform.position, new Quaternion(0, 0, 0, 0));
            enemyCount++;
        }
    }
}
