using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {
	private int A = 3;
	private int B = 3;
	private int C = 6;
	// Use this for initialization
	void Start () {
		if (A == B)
		{
			print("A is equal to B");
		}
		if (A != B)
		{
			print("A is not equal to B");
		}
		if (A < B)
		{
			print("A is less than B");
		}
		if (A > B)
		{
			print("A is more than B");
		}
		if (A <= B)
		{
			print("A is less than or equal to B");
		}
		if (A >= B)
		{
			print("A is more than or equal to B");
		}
	/*
		==
		!=
		<
		>
		<=
		>=
	 */
	}
}
