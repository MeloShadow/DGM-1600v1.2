using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = Random.Range(.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime * speed);
	}
}
