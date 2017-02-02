using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float horizontalSpeed = .5f;
	public float verticalSpeed = .2f;



	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))	
		{
			gameObject.transform.Translate (-horizontalSpeed, 0, 0);
		}	
		if(Input.GetKey(KeyCode.RightArrow))	
		{
			gameObject.transform.Translate (horizontalSpeed, 0, 0);
		}	
		if(Input.GetKey(KeyCode.UpArrow))	
		{
			gameObject.transform.Translate (0, verticalSpeed, 0);
		}	
		if(Input.GetKey(KeyCode.DownArrow))	
		{
			gameObject.transform.Translate (0, -verticalSpeed, 0);
		}	
		if(Input.GetKey(KeyCode.D))
		{
			gameObject.transform.Translate (Time.deltaTime, 0, 0);
		}
		if(Input.GetKey(KeyCode.A))
		{
			gameObject.transform.Translate (-Time.deltaTime, 0, 0);
		}
		if(Input.GetKey(KeyCode.W))
		{
			gameObject.transform.Translate (0, Time.deltaTime, 0);
		}
		if(Input.GetKey(KeyCode.S))
		{
			gameObject.transform.Translate (0, -Time.deltaTime, 0);
		}
	}
}
