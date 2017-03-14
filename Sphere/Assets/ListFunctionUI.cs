using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListFunctionUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CountToTen();
		print("----------------------------------------//---------------------------------");
		CountToTen();
		print("----------------------------------------//---------------------------------");
		CountToTen();
		print("----------------------------------------//---------------------------------");
	}
	
	void CountToTen() //count to ten
	{
		//could create a while loop
		int i = 1;
		while (i <= 10)
		{
			print(i);
			i++;
		}
		print("Congrats you counted to 10!");
	}

	//Adding animals
	



}