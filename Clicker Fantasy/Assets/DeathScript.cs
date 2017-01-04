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
			info.enemyHealth += 15;
			info.playerExperience += 50; 
		}

	}
}
