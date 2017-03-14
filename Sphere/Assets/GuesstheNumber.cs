using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesstheNumber : MonoBehaviour {
	private int minVal = 1;
	private int maxVal = 51;
	public int myNum = 30;

	// Use this for initialization
	void Start () {
				print("Alfred?");
				print("Yes Master Bruce?");
				print("Guess a number between 1 and 50!");
			int counter = 0;
			
		while (true)
		{	
			int randomNum = Random.Range(minVal, maxVal);
				print("Is " + randomNum + " your number Master Bruce?");
			counter++;
			if (randomNum == myNum)
			{
				print("Took you " + counter + " times to guess that Alfred");
				print("But there it is Alfred " + randomNum + "is the correct answer.");
				break;
			}
			if (randomNum > myNum)
			{
				print("No Alfred it's lower.");
				maxVal = randomNum;
			}
					//randomNum = Random.Range(minVal, randomNum);
					//print("Is " + randomNum + " your number Master Bruce?");
					//could just be an else statment here.
			if(randomNum < myNum)
			{
				print ("No Alfred it's higher.");
				minVal = randomNum;
			}
					//randomNum = Random.Range(randomNum, maxVal);
					//print("Is " + randomNum + " your number Master Bruce?");
					//randomNum = Random.Range(minVal, randomNum);
					//print("Is " + randomNum + " your number Master Bruce?");

					/* 
					if (randomNum < myNum)
					{
						print("haha no Alfred higher, higher!");
						randomNum = Random.Range(randomNum, maxVal);
					}

					if (randomNum == myNum)
					{
						print("There it is Alfred you've got it!");
						break;
					}
					*/
		}
	}
			/*Took a little while but I figured it out, just needed to make the break in the third statement inside the if statement
			Basically broke unity only 5 times..
			The computer(Alfred) is set to guess any random number between 1 and 50, had to write 51 so it would allow 50 to be selected.
				had the "user" (bruce) tell the computer if it was lower or higher, which I just realized will not quite work...
			Switched things around to try to get the number to reset and to be higher or lower than the previous number
				everything that I tried failed so for now keeping it simple until I can do some more research on how to skip the first
				randomly generated number.
			*/
}
