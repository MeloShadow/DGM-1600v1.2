using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 6.5f;
	private float length = 10.6f;
	private float height = 5.2f;
	private float tbase = 5f;
	private float theight = 12f;

	// Use this for initialization
	void Start () {
		//Find the diameter of a circle
		float diameter = 2 * radius;
		print ("The Diameter of the Circle with a radius " + radius + " is " + diameter);

		//Find the area of a circle
		float areaOfCircle = pi * Mathf.Pow(radius, 2);
		print ("The Area of the Circle with a radius of " + radius + " is " + areaOfCircle);

		//Find the circumference of a circle
		float circumferenceOfCircle = 2 * pi * radius;
		print ("The Circumference of the Circle with a radius of " + radius + " and a diameter of " + diameter + " is " + circumferenceOfCircle);

		//Find the Perimeter of a Rectangle
		float perimeterRectangle = (2 * length) + (2 * height);
		print ("The Perimeter of the Rectangle with a height of " + height + " and a length of " + length + " is " + perimeterRectangle);

		//Find the Area of a Rectangle
		float areaRectangle = length * height;
		print ("The Area of the Rectangle with a height of " + height + " and a length of " + length + " is " + areaRectangle);

		//Find the area of a Triangle
		float areaTriangle = (tbase * theight) / 2;
		print ("The Area of the Triangle with a base length of " + tbase + " and a height of " + theight + " is " + areaTriangle);
	}
}
