using UnityEngine;
using System.Collections;

public class whileloops : MonoBehaviour 
{
	int numducks = 0;
	// Use this for initialization
	void Start () 
	{
		while (numducks < 7) 
		{
			Debug.Log ("spawning Ducks now");
			numducks++;
		}
	}
	
	// Update is called once per frame
	void Update () 
		{
	
	}
}
