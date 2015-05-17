using UnityEngine;
using System.Collections;

public class ChangeScenes : MonoBehaviour {

    public void ChangeToScene (string sceneToChangeTo) 
	{
		Application.LoadLevel (sceneToChangeTo);
	}
	
		
}
