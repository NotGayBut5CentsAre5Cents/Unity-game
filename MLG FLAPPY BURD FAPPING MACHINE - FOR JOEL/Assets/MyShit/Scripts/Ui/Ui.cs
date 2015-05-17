using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour {

	// Use this for initialization
	public bool played = false;
	Text instruction;
	Text highscore;
	public AudioClip twentyOne;
	AudioSource twentyOneAudio;
	
	void Start () {
		instruction = GetComponent<Text>();
		highscore = GetComponent<Text>();
		twentyOneAudio = GetComponent<AudioSource> ();
	}
	void Update()
	{
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		instruction.fontSize = 30;

		if (dead.isDead) {
			instruction.fontSize = 20;
			instruction.text = "Restarting in 5 sec";

		} else if (dead.score == 21) 
		{
			instruction.text = "9 + 10";
			Time.timeScale = 0.3f;
			if (!played)
			{
				twentyOneAudio.PlayOneShot (twentyOne);
				played = true;
			}
		}else if(Time.timeScale != 0)
		{
			Time.timeScale = 1;
			instruction.text = dead.score.ToString (); 
		}


	}
}
