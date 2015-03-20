using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour 
{
	[Header("Gate Positions")]
	public GameObject[] gatePos;

	[Header("Gates")]
	public GameObject[] coloredPassableGates;
	public GameObject blackUnpassableGate;
	public GameObject[] coloredUnpassableGates;

	[Header("Settings")]
	public int numPassableGates = 1;
	public bool wrongColorGatesEnabled = false;

	private int passableGatesAdded = 0;
	private int currentGate = 0;

	void Start()
	{
		if(numPassableGates == 1)
		{
			foreach(GameObject gate in gatePos)
			{
				int randomNum = Random.Range(1,3);

				if(randomNum == 1 && passableGatesAdded < numPassableGates)
				{
					int randomGate = Random.Range(0,3);
					Instantiate(coloredPassableGates[randomGate],gatePos[currentGate].transform.position,Quaternion.identity);

					passableGatesAdded ++;
				}
				else
				{
					if(currentGate == 2 && passableGatesAdded == 0)
					{
						int randomGate = Random.Range(0,3);
						Instantiate(coloredPassableGates[randomGate],gatePos[currentGate].transform.position,Quaternion.identity);

					}
					else
					{
						if(!wrongColorGatesEnabled)
						{
							Instantiate(blackUnpassableGate,gatePos[currentGate].transform.position,Quaternion.identity);
						}
						else
						{
							int randomGate = Random.Range(0,3);
							Instantiate(coloredUnpassableGates[randomGate],gatePos[currentGate].transform.position,Quaternion.identity);
						}
					}
				}

				currentGate ++;
			}
		}

		if(numPassableGates == 2)
		{
			int randomNum_1 = Random.Range(0,2);
			int randomNum_2 = Random.Range(1,3);

			if(randomNum_1 == randomNum_2)
			{
				randomNum_2 = 2;
			}

			if(randomNum_1 != 0)
			{
				if(!wrongColorGatesEnabled)
				{
					Instantiate(blackUnpassableGate,gatePos[0].transform.position,Quaternion.identity);
				}
				else
				{
					int randomGate = Random.Range(0,3);
					Instantiate(coloredUnpassableGates[randomGate],gatePos[0].transform.position,Quaternion.identity);
				}
			}
			else if(randomNum_1 != 1 && randomNum_2 != 1)
			{
				if(!wrongColorGatesEnabled)
				{
					Instantiate(blackUnpassableGate,gatePos[1].transform.position,Quaternion.identity);
				}
				else
				{
					int randomGate = Random.Range(0,3);
					Instantiate(coloredUnpassableGates[randomGate],gatePos[1].transform.position,Quaternion.identity);
				}
			}
			else if(randomNum_2 != 2)
			{
				if(!wrongColorGatesEnabled)
				{
					Instantiate(blackUnpassableGate,gatePos[2].transform.position,Quaternion.identity);
				}
				else
				{
					int randomGate = Random.Range(0,3);
					Instantiate(coloredUnpassableGates[randomGate],gatePos[2].transform.position,Quaternion.identity);
				}
			}

			int randomGate_1 = Random.Range(0,3);
			int randomGate_2 = Random.Range(0,3);

			Instantiate(coloredPassableGates[randomGate_1],gatePos[randomNum_1].transform.position,Quaternion.identity);
			Instantiate(coloredPassableGates[randomGate_2],gatePos[randomNum_2].transform.position,Quaternion.identity);
		}
	}

}
