using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	
	// Use this for initialization
	public bool played = false;
	Text highscore;

	void Start () {
		highscore = GetComponent<Text> ();
	}
	void Update()
	{
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		highscore.fontSize = 20;

		if (Time.timeScale != 0)
		{
			highscore.text = "HighScore: " + PlayerPrefs.GetInt("highscore");
		}

		
	}
}
