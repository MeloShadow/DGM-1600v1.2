using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatements : MonoBehaviour {
	public int time = 10;
	public float grade = 95;
	// Use this for initialization
	void Start () {
		if (time < 12)
		{
			print("Good morning!");
		}
		else if (time == 12)
		{
			print("Lunch time!");
		}
		else if (time < 18)
		{
			print("Good afternoon!");
		}
		else 
		{
			print("Good evening!");
		}
		if (grade > 90)
		{
			print("A");
		}
		else if (grade > 80)
		{
			print("B");
		}
		else if (grade > 70)
		{
			print("C");
		}
		else 
		{
			print("What is going on?!");
		}
		
		
		
	}
}
