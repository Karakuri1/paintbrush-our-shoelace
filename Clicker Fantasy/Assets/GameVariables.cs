using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVariables : MonoBehaviour 
{
	public float enemyHealth = 15; 
	public float clickDamage = 1;
	public float playerExperience; 
	public int playerLevel = 1;
	public int enemyLevel = 1;
	public int enemiesDefeated = 0;

	public int currentZone; 
/*
	zones [0] = "Magma Fields";
	zones [1] = "Frozen Tundra";
	zones [2] = "Striking Peaks";
	zones [3] = "Swamplands";
	zones [4] = "Infinity Tower";
*/

	public int magmaFieldsLv = 1;
	public int frozenTundraLv = 1;
	public int strikingPeaksLv = 1;
	public int swamplandsLv = 1;
	public int infinityTowerLv = 1;

	// remove individual zone lvls and make it a single level that is shared by all 
	// create a formula for enemy health 15 * zone lvl  

	void Start ()
	{
		currentZone = 0;
	}
}
