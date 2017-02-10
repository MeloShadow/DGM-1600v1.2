using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementsandElses : MonoBehaviour {
	private int liveCount = 150000;
	private int deadCount = 160000;
	public int progressCount = 0;
	private float percentageDropped = .5f;
	public string dinosaur = "";
	private bool extinct = false;
	public string yourName = "";

	// Use this for initialization
	void Start () {
		//if nothing is entered for the name at start then show title and prompt for name
		if (yourName == "")
		{
			print("Welcome adventurer! Your task, to kill all the dinosaurs! Are you ready?");
		}
		//Name field if entered beforehand the get started! If not enter again and continue on!
		if (yourName == "")
		{
		 print("Enter your name");
		}
		else print("Okay " + yourName + " Let's get started");
		//Checking to see at the start if there's more to go in the world of dinosaurs
		if (liveCount != deadCount)
		{
			print("There's still more out there! Go get em!");
		}
		else print("You have protected this world!");
		//Letting you know when you start it up that there may be more out there
		if (liveCount > deadCount)
		{
			print("There's still more dinosaurs out there! Try a secret bunker or something.");
		}
		//checking if you've gotten to that halfway mark or whatever percentage is in there.
		if ((liveCount * percentageDropped) >= deadCount)
		{
			print("You've killed some but there are definitely more out there!");
		}
		if (progressCount <= deadCount)
		{
			bool extinct = true;
		//Success!
		if (extinct){
			print("You've really done it! I absolutely cannot believe it!");
		}
		}
		if (dinosaur == "Done")
		{
			print("Congratulations!");
		}
	}
	void Update () {
		//All these if statements are used when it happens, have to put them under the updat instead of start.
		//first objective/first kill displays this
		if (liveCount >= 159999)
		{
			print(" You've got a long way to go, keep on keeping on!");
		}
		//Boss battle!
		if (dinosaur == "Tyrannasaurus Rex")
		{
			print("The king of this island has appeared!");
		}
		//Enemy notification
		if (dinosaur == "New")
		{
			 print("A new enemy appears!");
		}
		//Letting you know you're halfway there
		if (liveCount == 80000)
		{
			print("You're halfway there!");
		}
		//Just in case someone finds secrets...
		if (liveCount > deadCount)
		{
			print("How'd you kill more than were alive?  Hacker...");
		}
	}
}
