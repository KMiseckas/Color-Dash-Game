using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleUI : MonoBehaviour 
{

	public void ToggleUIObjectOn(GameObject objectToToggleOn)
	{
		objectToToggleOn.SetActive (true);
	}

	public void ToggleUIObjectOff(GameObject objectToToggleOff)
	{
		objectToToggleOff.SetActive (false);
	}

}
