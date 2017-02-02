﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public float speed;
	public float rotX = 1f;
	//inserting rotX as the name for this float
	//rotating the x axis
	public float rotY = 1f;
	//rotating the y axis
	public float rotZ = 1f;
	//rotating the z axis
	// Use this for initialization
	void Start () {
		speed = Random.Range(.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime * speed);
	}
}
