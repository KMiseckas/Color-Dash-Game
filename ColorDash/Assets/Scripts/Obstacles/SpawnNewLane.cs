using UnityEngine;
using System.Collections;

public class SpawnNewLane : MonoBehaviour 
{

	[Header("Lane Gameobjects")]
	public GameObject lane_Intro;
	public GameObject lane_Level1;
	public GameObject lane_Level2;
	public GameObject lane_Level3;
	public GameObject lane_Level4;
	public GameObject lane_Level5;
	public GameObject lane_Level6;
	public GameObject lane_Level7;
	public GameObject lane_level8;
	public GameObject lane_Level9;
	public GameObject lane_Level10;

	[Header("Lane Holder")]
	public GameObject laneParent;

	[Header("Player")]
	public GameObject player;

	[Header("Settings")]
	public float laneLength = 19f;

	[Header("Test Settings")]
	[Range(0,10)]
	public int startOnLevel = 0;

	private int currentLane = 0;

	private float nextCheckPoint = 0;

	private Vector3 nextSpawnPoint;

	private GameObject laneToSpawn;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		nextSpawnPoint = new Vector3 (laneLength * 2, 0, 0);
		laneToSpawn = lane_Level1;

		switch(startOnLevel)
		{
		case 1:
			laneToSpawn = lane_Level1;
			break;
		case 2:
			currentLane = 15;
			break;
		case 3:
			currentLane = 30;
			break;
		case 4:
			currentLane = 45;
			break;
		case 5:
			currentLane = 60;
			break;
		case 6:
			currentLane = 75;
			break;
		case 7:
			currentLane = 90;
			break;
		case 8:
			currentLane = 105;
			break;
		case 9:
			currentLane = 120;
			break;
		case 10:
			currentLane = 135;
			break;
		}
	}

	void Update()
	{
		CheckWhatLaneToSpawn ();
		SpawnLane (laneToSpawn);
	}

	void CheckWhatLaneToSpawn()
	{
		//Can be used to add new kind of lanes ( harder difficulty ) every certain amount of lanes already spawned
		switch(currentLane)
		{
		case 15:
			laneToSpawn = lane_Level2;
			break;
		case 30:
			laneToSpawn = lane_Level3;
			break;
		case 45:
			laneToSpawn = lane_Level4;
			break;
		case 60:
			laneToSpawn = lane_Level5;
			break;
		case 75:
			laneToSpawn = lane_Level6;
			break;
		case 90:
			laneToSpawn = lane_Level7;
			break;
		case 105:
			laneToSpawn = lane_level8;
			break;
		case 120:
			laneToSpawn = lane_Level9;
			break;
		case 135:
			laneToSpawn = lane_Level10;
			break;
		}
	}

	void SpawnLane(GameObject lane)
	{
		//When player reaches the required point, a new lane is instantiated in its correct position
		if(player.transform.position.x > nextCheckPoint)
		{
			GameObject newLane = Instantiate(lane,nextSpawnPoint,Quaternion.identity) as GameObject;
			newLane.name = newLane.name + "_" + currentLane; //New name added to lane clone
			newLane.transform.parent = laneParent.transform; //Sets parent for instantiated objects

			//Increments the level / lane you are on, and changes the nextSpawnPoint and nextCheckPoint
			currentLane ++;
			nextSpawnPoint.x += laneLength;
			nextCheckPoint += laneLength; 
		}
	}
}
