using UnityEngine;
using System.Collections;

public class MG_SpawnEnemy : MonoBehaviour {

    float timer = 0f;

    public GameObject enemy;

    static int minWaveSpawn = 1;
    static int waveSpawn = 3;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

		SpawnNewEnemy ();

	}

	void SpawnNewEnemy(){

		timer += Time.deltaTime;
		
		if (timer > 5f)
		{
			int randomNumber = RandomNumber.GenerateRandomNumber(minWaveSpawn, waveSpawn);
			
			
			for (int i = 0; i < randomNumber; i++)
			{
				Instantiate(enemy, new Vector3(RandomNumber.GenerateRandomNumber((int)(this.transform.position.x - this.renderer.bounds.size.x/ 2), (int)(this.transform.position.x + this.renderer.bounds.size.x / 2)), (this.transform.position.y + this.renderer.bounds.size.y / 2), 0), new Quaternion(0, 0, 0, 0));
			}
			
			timer = 0;
		}

		}

    public static void IncreaseWaveSpawn()
    {
        waveSpawn++;
    }
}
