using UnityEngine;
using System.Collections;

public class AutomaticMovement : MonoBehaviour 
{

	[Header("Settings")]
	public float speed = 0;

	private bool isForwardMovementEnabled = true;

	#region property
	public bool SetForwardMovement
	{
		get 
		{
			return isForwardMovementEnabled;
		}
		set 
		{
			isForwardMovementEnabled = value;
		}
	}
	#endregion
	
	void Update()
	{
		if(isForwardMovementEnabled)
		{
			//Moves object by the same amount each frame
			transform.Translate (new Vector2 (1, 0) * Time.deltaTime * speed);
		}
		else
		{
			speed = Mathf.Lerp(speed,0,Time.deltaTime * 3);
			transform.Translate (new Vector2 (1, 0) * Time.deltaTime * speed);
		}
	}

}
