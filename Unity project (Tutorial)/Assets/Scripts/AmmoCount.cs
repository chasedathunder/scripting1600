using UnityEngine;
using System.Collections;

public class AmmoCount : MonoBehaviour {

	public int magazineSize = 31;
	public int reserveAmmo = 605;

	int ReduceReserves () {
		return reserveAmmo -= 31;
	}

	int Reload () {
		if (reserveAmmo >= 31) {
		return magazineSize = 31;
		print ("FullMagazine");
		}
		else (+
	}

	int ShootGun () {
		return magazineSize -=1;
	}

	void Update () {

		if (magazineSize <= 0) {
			magazineSize = 0;
			print ("reload");
		} 
		else {
			print (magazineSize);
			print (reserveAmmo);
		}
			
		if (reserveAmmo <= 0) {
			reserveAmmo = 0;
			print ("Out of Ammo!");
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			ShootGun ();
		}
		if (Input.GetKeyUp (KeyCode.R)) {
			Reload ();
			ReduceReserves ();
		}
	}

}
