﻿using UnityEngine;
using System.Collections;

public class Colt : Weapons {

	public int damage = 20;
	public int  magazine = 8;
	public int magazineSize = 8;
	public int reserves = 42;
	public int maxReserves = 126;
	public float reloadTime = 3.5f;


	public void stateChange() {
		
	}


	// Use this for initialization
	void Start () {
		weaponChange (damage, magazine, magazineSize, reserves, maxReserves, reloadTime);
	}
}
