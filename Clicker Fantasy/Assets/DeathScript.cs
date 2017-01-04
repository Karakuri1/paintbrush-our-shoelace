using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour 
{

	private GameObject gameInfo;
	private GameVariables info; 

	// Update is called once per frame
	void Update ()
	{
		gameInfo = GameObject.Find ("Click_box");
		info = gameInfo.GetComponent <GameVariables> ();

		if (info.enemyHealth <= 0)
		{
			info.enemyHealth += 15 * ;
			info.playerExperience += 50; 

			if (info.enemiesDefeated < 10)
			{
				info.enemiesDefeated += 1;
			}
			if (info.enemiesDefeated >= 10)
			{
				if (info.currentZone == 0)
				{
					info.magmaFieldsLv += 1;
				}
				if (info.currentZone == 1)
				{
					info.frozenTundraLv += 1;
				}
				if (info.currentZone  == 2)
				{
					info.strikingPeaksLv += 1;
				}
				if (info.currentZone == 3)
				{
					info.swamplandsLv += 1;
				}
				if (info.currentZone == 4)
				{
					info.infinityTowerLv += 1;
				}
			}
		}
	}
}
