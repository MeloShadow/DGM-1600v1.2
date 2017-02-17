using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {
	public int time = 10;

	private string creature = "dragon";
	private string appearance;
	private bool exists = true;

	// Use this for initialization
	void Start () {
		//Create a switch statement to determine the time and what to say at that time 
		/*	Letting the reader know what the appearance of the creature is like and what it sounds like.
			If the case for the creature is true then it'll print out the appearance for that true statement.
		 */
		switch (creature)
		{
			case "dragon":
				appearance = "Benedict Cumberbach!";
				break;
			case "chimera":
				appearance = "a lionsnakebird type of thing...";
				break;
			case "pegasus":
				appearance = "a glorious bird horse!";
				break;
			case "giant":
				appearance = "a huge thing that steps on \"litle people\"";
				break;
			case "megaladon":
				appearance = "a huge shark type of thing";
				break;
			case "ogre":
				appearance = "a big ugly yet small giantusually green";
				break;
			default: 
				exists = false;
				break;
		}
		if (exists)
		{
			print ("A " + creature + " looks like " + appearance + ".");
		}
		else
		{
			print(creature + " does not exist, no I'm not lying!");
		}
	}
}