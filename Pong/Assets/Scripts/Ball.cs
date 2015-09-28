using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	Vector3 reflectVelocity;

	// Use this for initialization
	void Start () {
		transform.rigidbody.velocity = new Vector3 (RandReverse (4), RandReverse(2), 0);
	}
	
	// Update is called once per frame
	void Update () {
		print (transform.rigidbody.velocity.y);
		reflectVelocity = transform.rigidbody.velocity;
	}

	// making a number neagitive randomly
	int RandReverse(int NumberToSwap)
	{
		int num = Random.Range (-1, 1);
		if (num < 0) 
		{
			NumberToSwap = NumberToSwap * -1;
		}
		return NumberToSwap;
	}

	//handles impacts
	void OnCollisionEnter (Collision coll)
	{

		if (coll.gameObject.tag == "Paddle") 
		{
			reflectVelocity.x = reflectVelocity.x * -1.05f;
			transform.rigidbody.velocity = reflectVelocity;
		}

		if (coll.gameObject.tag == "Wall")
		{
			reflectVelocity.y = reflectVelocity.y * -1;
			transform.rigidbody.velocity = reflectVelocity;
		}
	}

	//Destroys and creates a new ball
	void OnTriggerStay ()
	{
		Destroy (gameObject);
		Instantiate (Resources.Load ("Ball"));
	}
}
