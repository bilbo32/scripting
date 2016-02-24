using UnityEngine;
using System.Collections;

public class Datatypes : MonoBehaviour 
{

	// Use this for initialization

		void Start () 
		{
			//Value type variable
			Vector3 pos = transform.position;
		 //Vector3(0,2,0) should move the object up 
			pos = new Vector3(0, 2, 0);
			
			//Reference type variable
			Transform tran = transform;
			tran.position = new Vector3(0, 2, 0);
		}
	}
	
	

