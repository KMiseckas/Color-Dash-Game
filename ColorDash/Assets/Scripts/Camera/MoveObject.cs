using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour 
{

	[Header("Settings")]
	public float speed = 0;

	private bool moveEnabled = false;
	private Vector3 targetPos = Vector3.zero;
	void Update()
	{
		if(moveEnabled)
		{
			transform.position = Vector3.Lerp (transform.position, targetPos, Time.deltaTime * speed * 10);
		}
	}

	public void Move(Vector3 targetPos, bool enable)
	{
		this.targetPos = targetPos;
		moveEnabled = enable;
	}

}
