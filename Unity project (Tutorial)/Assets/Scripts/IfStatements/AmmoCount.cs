using UnityEngine;
using System.Collections;

public class AmmoCount : MonoBehaviour {

	public int magazineSize;
	public int reserveAmmo;

	int ReduceReserves () {
		return reserveAmmo -= 5;
	}

	void Reload () {
		if (reserveAmmo >= 5) {
			magazineSize = 5;
			print ("FullMagazine");
		}
		else {
			print ("Out of Ammo");
		}
			}

	void ShootGun () {
		magazineSize --;
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
