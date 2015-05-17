using UnityEngine;
using UnityEngine.UI;

public class UiStats : MonoBehaviour {
	
	// Use this for initialization
	public bool played = false;
	Text totalJumps;
	
	void Start () {
		totalJumps = GetComponent<Text>();
	}
	void Update()
	{
		totalJumps.fontSize = 14;

		totalJumps.text = "Total jumps: " + PlayerPrefs.GetInt("TotalJumps"); 

	}
}
