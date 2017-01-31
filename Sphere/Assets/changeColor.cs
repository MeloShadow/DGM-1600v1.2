using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		//Make the color red
		if(Input.GetKeyDown(KeyCode.R))	
		{
			GetComponent<Renderer> ().material.color = Color.red;
		}
		//Make the color Green
		if(Input.GetKeyDown(KeyCode.G))	
		{
			GetComponent<Renderer> ().material.color = Color.green;
		}
		//Make the color Blue
		if (Input.GetKeyDown(KeyCode.B))	
		{
			GetComponent<Renderer> ().material.color = Color.blue;
		}
		//Make the color Black
		if (Input.GetKeyDown(KeyCode.Space))	
		{
			GetComponent<Renderer> ().material.color = Color.black;
		}
		//Make the color White
		if (Input.GetKeyDown(KeyCode.Backspace))	
		{
			GetComponent<Renderer> ().material.color = Color.white;
		}
		//Make the color Yellow
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			GetComponent<Renderer> ().material.color = Color.yellow;
		}
	}
}
