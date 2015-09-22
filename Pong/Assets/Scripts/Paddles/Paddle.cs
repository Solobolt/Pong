using UnityEngine;
using System.Collections;

public abstract class Paddle : MonoBehaviour {

	public GameManager gameManager;
	int speed = 5;

	//Runs as soon as the program starts
	void Start()
	{
		gameManager = FindObjectOfType<GameManager> ();
	}

	// Handles Movement upwards
	public void MoveUp()
	{
		transform.position = transform.position + (new Vector3 (0,speed * Time.deltaTime,0));
	}

	// handles Movement downwards
	public void MoveDown()
	{
		transform.position = transform.position - (new Vector3 (0,speed * Time.deltaTime,0));
	}



}
