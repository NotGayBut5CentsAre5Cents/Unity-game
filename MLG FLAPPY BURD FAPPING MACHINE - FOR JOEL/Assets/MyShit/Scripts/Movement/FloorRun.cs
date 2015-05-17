using UnityEngine;


public class FloorRun : MonoBehaviour
{
	public Vector2 velocity = new Vector2(-4, 0);
	
	// Use this for initialization
	void Update()
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
	}
}