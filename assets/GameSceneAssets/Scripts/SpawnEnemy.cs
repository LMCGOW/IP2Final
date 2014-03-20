﻿using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

    static int enemyCount = 0;
    public static int maxEnemyCount = 20;

	public int setMaxEnemyCount = 0;

    public GameObject enemy;

	// Use this for initialization
	void Start () {

        enemyCount = 0;

	}
	
	// Update is called once per frame
	void Update () {

		maxEnemyCount = setMaxEnemyCount;

        SpawnEnemies();

	}

    public void SpawnEnemies()
    {
        if (RandomNumber.GenerateRandomNumber(0, 20000) < 2 && enemyCount < maxEnemyCount)
        {
            Instantiate(enemy, this.transform.position, new Quaternion(0, 0, 0, 0));
            enemyCount++;
        }
    }
}
