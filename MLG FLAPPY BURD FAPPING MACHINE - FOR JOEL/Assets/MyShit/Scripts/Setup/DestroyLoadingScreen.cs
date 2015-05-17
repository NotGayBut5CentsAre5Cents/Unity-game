using UnityEngine;
using System.Collections;

public class DestroyLoadingScreen : MonoBehaviour {
	public GameObject pupes;
	// Update is called once per frame
	void Update () 
	{
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		if (dead.isPlaying == true) 
		{
			Destroy (pupes);
		}
	}
}
