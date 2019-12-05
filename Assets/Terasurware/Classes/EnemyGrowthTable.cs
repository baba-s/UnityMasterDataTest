using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyGrowthTable : ScriptableObject
{	
	public List<Param> param = new List<Param> ();

	[System.SerializableAttribute]
	public class Param
	{
		
		public int enemyGrowthId;
		public int lap;
		public int hp;
		public int attack;
		public int exp;
	}
}