using UnityEngine;
using System.Collections;

public class RandomNumber : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static int GenerateRandomNumber(int max, int min)
    {
        int random = Random.Range(max, min);

        return random;
    }

	public static float GenerateRandomNumber(int max, int min, bool convertToFloat)
	{
		int random = Random.Range (max, min);
		
		return random/100;
	}

}
