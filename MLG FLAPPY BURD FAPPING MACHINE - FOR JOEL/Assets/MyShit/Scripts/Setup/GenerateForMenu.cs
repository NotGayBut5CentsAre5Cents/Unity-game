using UnityEngine;

public class GenerateForMenu : MonoBehaviour
{
	public GameObject floor;
	//public GameObject weed;
	public float HighScale = 1;
	
	// Use this for initialization
	void Start()
	{
		float spawnSpeedF = 0.5f/HighScale;
		InvokeRepeating ("CreateFloor", spawnSpeedF, spawnSpeedF);
		//InvokeRepeating ("CreateWeed", 20, 20);
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