using UnityEngine;
using UnityEngine.UI;

public class UIStats3 : MonoBehaviour {
	
	// Use this for initialization
	public bool played = false;
	Text totalScore;
	
	void Start () {
		totalScore = GetComponent<Text>();
	}
	void Update()
	{
		totalScore.fontSize = 14;
		
		totalScore.text = "Total score: " + PlayerPrefs.GetInt("TotalScore"); 
		
	}
}
