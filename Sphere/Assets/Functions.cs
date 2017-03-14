using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Functions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void CurrentTime()
	{
		string greeting;
		int hour = DateTime.Now.Hour;
		if (hour < 12)
			greeting = "Good Morning";
		else if (hour <17)
			greeting = "Good Afternoon";
		else
			greeting = "Good Evening";

		print(string.Format("{0}, the current time is {1}", greeting, DateTime.Now.ToShortTimeString()));
	}




}
