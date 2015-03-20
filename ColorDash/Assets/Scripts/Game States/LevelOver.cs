using UnityEngine;
using System.Collections;

public class LevelOver : MonoBehaviour 
{

	private GameObject player;
	private GameObject cam;

	public GameObject endLevelUI;

	Score scoreScript;
	AutomaticMovement playerForwardMovement;
	AutomaticMovement cameraForwardMovement;
	InputMovement playerLaneSwitching;
	ColorChange playerColorChanging;
	MoveObject moveObject;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		cam = Camera.main.gameObject;

		scoreScript = player.GetComponent<Score> ();
		playerForwardMovement = player.GetComponent<AutomaticMovement> ();
		playerLaneSwitching = player.GetComponent<InputMovement> ();
		cameraForwardMovement = cam.GetComponent<AutomaticMovement> ();
		playerColorChanging = player.GetComponent<ColorChange> ();

	}

	public void EndLevel()
	{
		//On level end, call the following methods
		DisableMovements ();
		scoreScript.CheckHighScore (scoreScript.ThisLevelScore);
		ProgressGameOverCount ();
		Invoke ("LoadEndLevelUI", 1f);
	}

	void ProgressGameOverCount()
	{
		if(CheckIfAdvertOn.gameOverCount > 3)
		{
			CheckIfAdvertOn.gameOverCount = 0;
		}

		CheckIfAdvertOn.gameOverCount ++;
	}

	void DisableMovements()
	{
		//Disable any movement from the player or the camera
		playerForwardMovement.SetForwardMovement = false;
		cameraForwardMovement.SetForwardMovement = false;
		playerLaneSwitching.SetLaneSwitching = false;

		//Disable color changing
		playerColorChanging.setColorChange = false;
	}

	void LoadEndLevelUI()
	{
		endLevelUI.SetActive (true);
	}



}
