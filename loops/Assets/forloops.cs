using UnityEngine;
using System.Collections;

public class forloops : MonoBehaviour 
{
	public int time = 25;
	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < time ; i++)
			{ 
			Debug.Log("counting down to finish" + i);
			}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
