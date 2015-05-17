using UnityEngine;

public class FappyBurdMovement : MonoBehaviour
{
	public float jumpForce = 300f;
	public int totalDeaths = 0;
	public int totalJumps = 0;
	public int totalScore = 0;
	public GameObject pupe;
	public GameObject floor;
	public bool isDead = false;
	public bool isPlaying = false;
	public int score = 0;
	public bool isHigh = false;
	public bool onceDead = true;
	public AudioClip hitmarker;
	AudioSource hitmarkerAudio;

	void Start()
	{
		Time.timeScale = 0;
		hitmarkerAudio = GetComponent<AudioSource> ();
		if(!PlayerPrefs.HasKey("HighScore"))
		{
			PlayerPrefs.SetInt("HighScore", 0);
		}
	}
	void Update ()
	{
		if (isDead == false)
		{
			// Jump
			if (Input.GetKeyUp ("space") || Input.GetMouseButtonDown (0)) 
			{
				totalJumps++;
				if (PlayerPrefs.GetInt ("TotalJumps") < totalJumps) 
				{
					PlayerPrefs.SetInt ("TotalJumps", totalJumps);
					totalJumps = PlayerPrefs.GetInt ("TotalJumps");
				}
				isPlaying = true;
				Time.timeScale = 1;
				GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpForce);
			}


			Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
			if (screenPosition.y > Screen.height || screenPosition.y < 0) 
			{
				Die ();
			}
			if (GetComponent<Rigidbody2D> ().velocity.y > 0) 
			{
				float angle1 = Mathf.Lerp (0, 45, (GetComponent<Rigidbody2D> ().velocity.y / 3f));
				transform.rotation = Quaternion.Euler (0, 0, angle1);
			} else {
				float angle = Mathf.Lerp (0, -45, (-GetComponent<Rigidbody2D> ().velocity.y / 3f));
				transform.rotation = Quaternion.Euler (0, 0, angle);
			}
			PlayerPrefs.Save();
		}
	}
	
	// Die by collision
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals ("Pupes") || other.gameObject.tag.Equals ("Floor")) 
		{
			Die ();
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Point")) 
		{
			score++;
			totalScore++;
			if (PlayerPrefs.GetInt ("TotalScore") < totalScore) 
			{
				PlayerPrefs.SetInt ("TotalScore", totalScore);
				totalScore = PlayerPrefs.GetInt ("TotalScore");
			}
			Debug.Log (score);
		}
		if(other.gameObject.CompareTag("Weed"))
		{
			isHigh=true;
		}
	}
	void Die()
	{
		isDead = true;
		totalDeaths++;
		if (PlayerPrefs.GetInt ("highscore")<score)
		{
			PlayerPrefs.SetInt ("highscore" , score);
		}
		if (PlayerPrefs.GetInt ("TotalDeaths") < totalDeaths) 
		{
			PlayerPrefs.SetInt ("TotalDeaths", totalDeaths);
			totalDeaths = PlayerPrefs.GetInt ("TotalDeaths");
		}
		if (onceDead)
		{
			hitmarkerAudio.PlayOneShot (hitmarker);
			onceDead = false;
		}
		PlayerPrefs.Save();
		InvokeRepeating ("Restart", 5, 10);

	}

	void Restart()
	{
		CancelInvoke ("Restart");
		Application.LoadLevel(Application.loadedLevel);
	}


}