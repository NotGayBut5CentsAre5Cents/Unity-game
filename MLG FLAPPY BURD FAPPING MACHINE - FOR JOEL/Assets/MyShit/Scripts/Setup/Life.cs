using UnityEngine;

public class Life : MonoBehaviour
{
	public GameObject pupes;
	public GameObject floor;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("DestroyPipes", 7, 7);
		InvokeRepeating("DestroyFloor", 4, 4);
		
	}
	void DestroyFloor()
	{
		if (floor != null)
		{
			Destroy(floor);
		}
	}
	void DestroyPipes()
	{
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		if (pupes != null && !dead.isDead)
		{
			Destroy(pupes);
		}
	}
}
