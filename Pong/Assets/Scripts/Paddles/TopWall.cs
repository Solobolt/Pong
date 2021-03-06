﻿using UnityEngine;
using System.Collections;

public class TopWall : MonoBehaviour {
	
	Camera mainCamera;
	float thickness=0.5f;
	
	// Use this for initialization
	void Start () {
		mainCamera=FindObjectOfType<Camera>();
	}
	
	void Update()
	{
		transform.localScale = new Vector3 (mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x,thickness,1);
		transform.position = new Vector3 (0f,mainCamera.ScreenToWorldPoint(new Vector3 (0f, Screen.height,0f)).y - (thickness/2),0);
	}
}
