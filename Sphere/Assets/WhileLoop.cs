using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour {
	private int bottles = 0;
	public int maxBottles = 25;

	private bool gameOn = true;
	private bool gameOff = true;
	// Use this for initialization
	void Start () {
		/*while(bottles < maxBottles)
		{
			if (bottles)
			{
				print (bottles + " take two down, share em around")
			}
			maxBottles-=1;
			print(bottles + " bottles of BEER on the wall");
			
		}
			print("All done!");
			*/




		while (gameOn == true)
		{
			print (bottles + " bottles of BEER on the wall");
			bottles++;
			if(bottles ==  maxBottles)
			{
				break;
			}
		}
	}
}
