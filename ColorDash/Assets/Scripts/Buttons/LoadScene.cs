using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour 
{
	public void LoadNewScene(string scene)
	{
		//Load scene of specified name
		Application.LoadLevel (scene);
	}
}
