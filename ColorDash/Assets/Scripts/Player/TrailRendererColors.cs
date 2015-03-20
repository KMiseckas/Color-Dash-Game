using UnityEngine;
using System.Collections;

public class TrailRendererColors : MonoBehaviour 
{
	
	public Material trailMat;

	public Color col_1;
	public Color col_2;
	public Color col_3;
	public Color defaultCol;

	void Start()
	{
		SetDefaultTrail ();
	}

	public void ChangeColorOfTrail(int colNum)
	{
		//Change color of trail , based on which color is selected
		switch(colNum)
		{
		case 1:
			//print ("blue");
			trailMat.SetColor("_TintColor",col_1);
			break;
		case 2:
			trailMat.SetColor("_TintColor",col_2);
			break;
		case 3:
			trailMat.SetColor("_TintColor",col_3);
			break;
		}
	}

	public void SetDefaultTrail()
	{
		trailMat.SetColor("_TintColor",defaultCol);
	}
}
