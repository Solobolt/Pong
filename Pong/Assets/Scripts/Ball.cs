﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	Vector3 reflectVelocity;

	// Use this for initialization
	void Start () {
		transform.rigidbody.velocity = new Vector3 (2, 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
		print (transform.rigidbody.velocity.y);
		reflectVelocity = transform.rigidbody.velocity;
	}

	//handles impacts
	void OnCollisionEnter (Collision coll)
	{

		if (coll.gameObject.tag == "Paddle") 
		{
			reflectVelocity.x = reflectVelocity.x * -1;
			transform.rigidbody.velocity = reflectVelocity;
		}

		if (coll.gameObject.tag == "Wall")
		{
			reflectVelocity.y = reflectVelocity.y * -1;
			transform.rigidbody.velocity = reflectVelocity;
		}
	}
}
