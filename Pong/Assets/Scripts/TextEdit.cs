using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextEdit : MonoBehaviour {

	public Text value;
	public string ForeText;
	
	public void SetValue(int score)
	{
		value.text = (ForeText)+(score.ToString());
	}
}
