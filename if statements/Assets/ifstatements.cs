using UnityEngine;
using System.Collections;

public class ifstatements: MonoBehaviour {

	public float answer = 120;
	public float successptlim = 75;
	public float failurelim = 40;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	  			
				
				void Update ()
				{
					if(Input.GetKeyDown(KeyCode.Space))
						OperationC();
					
					answer -= Time.deltaTime * 6f;
				}
				
				
				void OperationC ()
				{
					
					if(answer >= successptlim)
					{
						
						print("SUCCESS");
					}
					
					else if(answer < failurelim)
					{
						
						print("operation failed");
					}
					
					else
					{

						print("Work in progress");
					}


				}
	}


