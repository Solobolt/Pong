using UnityEngine;
using System.Collections;

public class P2Paddle : Paddle {

	// Update is called once per frame
	public void Update () {
		if (Input.GetKey("up"))
		{
			MoveUp();
		} else if (Input.GetKey("down"))
		{
			MoveDown ();
		}
	}

	//handles impacts
	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Ball") 
		{
			gameManager.player2Score ++;
		}
	}
}
