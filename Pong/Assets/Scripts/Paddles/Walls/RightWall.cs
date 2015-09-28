using UnityEngine;
using System.Collections;

public class RightWall : MonoBehaviour {

	BoxCollider coll;
	Camera mainCamera;
	float thickness=10f;
	
	// Use this for initialization
	void Start () {
		coll = this.GetComponent <BoxCollider>();
		mainCamera=FindObjectOfType<Camera>();
	}
	
	void Update()
	{
		transform.localScale = new Vector3 (thickness, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
		transform.position = new Vector3 (mainCamera.ScreenToWorldPoint(new Vector3 (Screen.width,0f,0f)).x + (thickness/2), 0f);
	}
}
