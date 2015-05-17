using UnityEngine;
using System.Collections;

public class Pauser : MonoBehaviour {

	// Use this for initialization
	public void Pause()
	{
		Time.timeScale = 0;
	}
}
