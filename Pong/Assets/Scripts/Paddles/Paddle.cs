using UnityEngine;
using System.Collections;

public abstract class Paddle : MonoBehaviour {
	public Camera mainCamera;
	public GameManager gameManager;
	public float distanceFromWall= 20;

	int speed = 5;

	float topWall;
	float bottomWall;


	//Runs as soon as the program starts
	void Start()
	{
		mainCamera = FindObjectOfType<Camera> ();
		gameManager = FindObjectOfType<GameManager> ();
		StartingLocation ();
		topWall = (new Vector3 (0f,mainCamera.ScreenToWorldPoint(new Vector3 (0f, Screen.height,0f)).y,0).y) - (transform.localScale.y);
		bottomWall =  (new Vector3 (0f,mainCamera.ScreenToWorldPoint(new Vector3 (0f, 0f ,0f)).y).y) + (transform.localScale.y);
	}

	// Handles Movement upwards
	public void MoveUp()
	{
		if (!(transform.position.y >= topWall))
		{
			transform.position = (transform.position + (new Vector3 (0,speed * Time.deltaTime,0)));
		}
	}

	// handles Movement downwards
	public void MoveDown()
	{
		if(!(transform.position.y <= bottomWall))
		{
			transform.position = transform.position - (new Vector3 (0,speed * Time.deltaTime,0));
		}
	}

	public abstract void StartingLocation();

}
