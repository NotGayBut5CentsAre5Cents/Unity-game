using UnityEngine;
using UnityEngine.UI;

public class UiStats2 : MonoBehaviour {
	
	// Use this for initialization
	public bool played = false;
	Text totalDeaths;
	
	void Start () {
		totalDeaths = GetComponent<Text>();
	}
	void Update()
	{
		totalDeaths.fontSize = 14;
		
		totalDeaths.text = "Total Deaths: " + PlayerPrefs.GetInt("TotalDeaths"); 
		
	}
}
