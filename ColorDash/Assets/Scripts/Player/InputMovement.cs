using UnityEngine;
using System.Collections;

public class InputMovement : MonoBehaviour 
{
	[Header("Positions")]
	public GameObject lanePos_1;
	public GameObject lanePos_2;
	public GameObject lanePos_3;

	[Header("Settings")]
	public float changeLaneSpeed = 0;
	public float minSwipeDistY = 0;

	private int lane = 2;

	private float halfPixelWidth = 0;
	private float startSwipeY = 0;
	private float endSwipeY = 0;

	private bool isLaneSwitchingEnabled = true;
	private bool blockSwipe = false;

	private Touch currentTouch;

	#region properties
	public bool SetLaneSwitching
	{
		get 
		{
			return isLaneSwitchingEnabled;
		}
		set 
		{
			isLaneSwitchingEnabled = value;
		}
	}
	#endregion

	void Start()
	{
		halfPixelWidth = Camera.main.pixelWidth/2;
	}

	void Update()
	{
		if(isLaneSwitchingEnabled)
		{
			GetInput ();
			GetCorrectLane();
		}
	}

	void GetInput()
	{

		if (Input.touchCount > 0) 
		{
			//print ("Stage 1");
			foreach (Touch touch in Input.touches) 
			{
				//print ("Stage 2");
				if (touch.position.x > halfPixelWidth) 
				{
					//print ("Stage 3");
					currentTouch = touch;

					switch (currentTouch.phase) 
					{
					case TouchPhase.Began:
						startSwipeY = currentTouch.position.y;
						endSwipeY = currentTouch.position.y;
						break;

					case TouchPhase.Moved:
						endSwipeY = currentTouch.position.y;
						if(!blockSwipe)
						{
							if((startSwipeY - endSwipeY) < -minSwipeDistY)
							{
								if(lane != 1)
								{
									lane --;
								}
								blockSwipe = true;
							}
							else if((startSwipeY - endSwipeY) > minSwipeDistY)
							{
								if(lane != 3)
								{
									lane ++;
								}
								blockSwipe = true;
							}
						}
						break;

					case TouchPhase.Ended:
						endSwipeY = 0;
						startSwipeY = 0;
						blockSwipe = false;
						break;
					}

					break;
				}
			}
		}







		// PC TESTING CODE BELOW --------------------
		if(Input.GetKeyDown(KeyCode.A))
		{
			if(lane != 1)
			{
				lane --;
			}
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
			if(lane != 3)
			{
				lane ++;
			}
		}
		//----------------------------------------------*/
	}

	void GetCorrectLane()
	{
		//Find the correct lane the player should be on and call the method to change lanes
		switch(lane)
		{
		case 1:
			ChangePosition(lanePos_1.transform.position.y);
			break;
		case 2:
			ChangePosition(lanePos_2.transform.position.y);
			break;
		case 3:
			ChangePosition(lanePos_3.transform.position.y);
			break;
		}
	}

	void ChangePosition(float yPos)
	{
		//lerps from current position to target position on the lane ( y coordinate only )
		float y;
		y = Mathf.Lerp (transform.position.y, yPos, Time.deltaTime * changeLaneSpeed);
		transform.position = new Vector3 (transform.position.x, y, 0);
	}
}
