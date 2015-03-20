using UnityEngine;
using System.Collections;

public class Difficulty : MonoBehaviour 
{
	public GameObject player;
	public GameObject cam;

	public static string difficulty = "None";

	AutomaticMovement speedScriptPlayer;
	AutomaticMovement speedScriptCamera;

	void Start()
	{
		speedScriptPlayer = player.GetComponent<AutomaticMovement> ();
		speedScriptCamera = cam.GetComponent<AutomaticMovement> ();

		switch(difficulty)
		{
		case "Easy":
			speedScriptPlayer.speed = 9;
			speedScriptCamera.speed = 9;
			break;
		case "Normal":
			speedScriptPlayer.speed = 12;
			speedScriptCamera.speed = 12;
			break;
		case "Hard":
			speedScriptPlayer.speed = 14;
			speedScriptCamera.speed = 14;
			break;
		}
	}

	public void SetDifficulty(string diff)
	{
		difficulty = diff;
	}
}
