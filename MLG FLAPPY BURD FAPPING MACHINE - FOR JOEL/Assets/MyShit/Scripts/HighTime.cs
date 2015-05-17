using UnityEngine;
using System.Collections;

public class HighTime : MonoBehaviour {
	
	void Update()
	{	
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		if (dead.isHigh) 
		{
			GetComponent<BoxCollider2D> ().isTrigger = true;
		}
	}
}
