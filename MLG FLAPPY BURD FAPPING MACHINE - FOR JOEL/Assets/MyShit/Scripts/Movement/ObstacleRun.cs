using UnityEngine;

public class ObstacleRun : MonoBehaviour
{
	public Vector2 velocity = new Vector2(-4, 0);
	public float range = 4;
	// Use this for initialization
		
	void Start()
	{
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		if (dead.isHigh) 
		{
			GetComponent<Rigidbody2D> ().velocity = velocity * 3;
		} else 
		{
			GetComponent<Rigidbody2D> ().velocity = velocity;
		}
			transform.position = new Vector3 (transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}

	void Update()
	{	
		GameObject go = GameObject.Find ("Fappy Burd");
		FappyBurdMovement dead = go.GetComponent <FappyBurdMovement> ();
		if(dead.isDead==true)
		{
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		}
	}
}