using UnityEngine;
using System.Collections;

public class P1Paddle : Paddle {

	// Update is called once per frame
	public void Update () {
		if (Input.GetKey("w"))
		{
			MoveUp();
		} else if (Input.GetKey("s"))
		{
			MoveDown ();
		}
	}

	//handles impacts
	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Ball") 
		{
			gameManager.player1Score ++;
		}
	}

	override public void StartingLocation ()
	{
		transform.position = new Vector3 (mainCamera.ScreenToWorldPoint(new Vector3(distanceFromWall, 0f,0f)).x,0,0);
	}
}
