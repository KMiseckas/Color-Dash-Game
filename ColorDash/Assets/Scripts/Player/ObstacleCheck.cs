using UnityEngine;
using System.Collections;

public class ObstacleCheck : MonoBehaviour 
{
	Score score;
	ColorChange color;
	public GameObject trail;
	TrailRendererColors trailColors;

	void Start()
	{
		score = GetComponent<Score> ();
		color = GetComponent<ColorChange> ();
		trailColors = trail.GetComponent<TrailRendererColors> ();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//Check which gate has been hit, and act accordingly
		if(col.gameObject.tag == "UnpassableGate")
		{
			HitObstacle();
		}
		else if(col.gameObject.tag == "Col_1_Gate")
		{
			if(color.CurrentColor == "Col_1")
			{
				score.ThisLevelScore ++;
			}
			else
			{
				HitObstacle();
			}
		}
		else if(col.gameObject.tag == "Col_2_Gate")
		{
			if(color.CurrentColor == "Col_2")
			{
				score.ThisLevelScore ++;
			}
			else
			{
				HitObstacle();
			}
		}
		else if(col.gameObject.tag == "Col_3_Gate")
		{
			if(color.CurrentColor == "Col_3")
			{
				score.ThisLevelScore ++;
			}
			else
			{
				HitObstacle();
			}
		}
	}

	void HitObstacle()
	{
		//Call the method on the script of level state manager
		GameObject stateManager = GameObject.FindGameObjectWithTag ("LevelStateManager");
		LevelOver endLevelScript = stateManager.GetComponent<LevelOver> ();

		color.SetColor (4);
		trailColors.SetDefaultTrail ();

		endLevelScript.EndLevel();
	}
	
}
