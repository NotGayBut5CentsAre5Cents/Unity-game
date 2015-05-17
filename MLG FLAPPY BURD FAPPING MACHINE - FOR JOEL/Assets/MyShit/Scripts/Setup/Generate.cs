using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject pupes;
	public GameObject floor;
	//public GameObject weed;
	public float HighScale = 1;

	// Use this for initialization
	void Start()
	{
		float spawnSpeedF = 0.5f/HighScale;
		float spawnSpeedP = 1.5f/HighScale;
		InvokeRepeating ("CreatePupes", spawnSpeedP, spawnSpeedP);
		InvokeRepeating ("CreateFloor", spawnSpeedF, spawnSpeedF);
		//InvokeRepeating ("CreateWeed", 20, 20);
	}			

	void Update()
	{
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		if (dead.isDead) 
		{
			CancelInvoke("CreatePupes");
		}
		if (dead.isHigh) 
		{
			HighScale = 3;
		}
	}
	void CreatePupes()
	{
		Instantiate(pupes);
	}
	void CreateFloor()
	{
		Instantiate(floor);
	}
	void CreateWeed()
	{
		//Instantiate(weed);
	}
	
	
}