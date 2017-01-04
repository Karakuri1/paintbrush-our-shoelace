using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour 
{

	private GameObject gameInfo;
	private GameVariables info; 
	
	// Update is called once per frame
	void Update () 
	{
		gameInfo = GameObject.Find ("Click_box");
		info = gameInfo.GetComponent <GameVariables> ();

		if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1)) 
		{
			info.enemyHealth -= info.clickDamage;
			Debug.Log (info.enemyHealth);

		}

	}
}
