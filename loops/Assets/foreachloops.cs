﻿using UnityEngine;
using System.Collections;

public class foreachloops : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string [] strings = new string[3];
		strings [0] = "First";
		strings [1] = "Second";
		strings [2] = "Third";
		foreach (string item in strings) 
		{
			print (item);
		}		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
