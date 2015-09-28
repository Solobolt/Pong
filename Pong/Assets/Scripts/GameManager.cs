using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int player1Score = 0;
	public int player2Score = 0;
	UIController uiController;

	// Use this for initialization
	void Start () {
		uiController = FindObjectOfType<UIController>();
	}
	
	// Update is called once per frame
	void Update () {
		uiController.score1.SetValue (player1Score);
		uiController.score2.SetValue (player2Score);
	}

}
