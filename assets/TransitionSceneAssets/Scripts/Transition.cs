using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {

    float transitionTimer = 1f;
    public GameObject[] transitionAnimation = new GameObject[5];

    int currentFrame = 4;
    bool destroyPrevious = false;

    GameObject current;

	// Use this for initialization
	void Start () {

        current = (GameObject)Instantiate(transitionAnimation[currentFrame], new Vector3(-12.15166f, -5.83063f, 0), new Quaternion(0, 0, 0, 0));

	}
	
	// Update is called once per frame
	void Update () {

        transitionTimer -= Time.deltaTime;


        if (currentFrame < 0)
        {
            Application.LoadLevel(3);
        }

        if (transitionTimer <= 0)
        {
            currentFrame--;
            transitionTimer = 1f;
            destroyPrevious = true;
        }

        if (destroyPrevious && currentFrame >= 0)
        {
            Destroy(current);
            current = (GameObject)Instantiate(transitionAnimation[currentFrame], new Vector3(-12.15166f, -5.83063f, 0), new Quaternion(0, 0, 0, 0));
            destroyPrevious = false;
        }
   
	}
}
