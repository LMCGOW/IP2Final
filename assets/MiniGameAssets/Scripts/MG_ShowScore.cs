﻿using UnityEngine;
using System.Collections;

public class MG_ShowScore : MonoBehaviour {

    static int score= 0; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void AddScore(int addition)
    {
        score += addition;
    }

  
}
