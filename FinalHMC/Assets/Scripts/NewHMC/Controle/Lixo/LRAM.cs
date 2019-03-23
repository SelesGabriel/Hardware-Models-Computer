using UnityEngine;
using System.Collections;

public class LRAM : MonoBehaviour {

	GameObject Lata;

	void Update () {
		Lata = GameObject.Find ("LataLixo");

	

		if (Vector3.Distance (Lata.transform.position, transform.position) < 5) {
			if (GameObject.FindWithTag ("RAM")) {
				Destroy (GameObject.FindWithTag ("RAM"));
			}
		}
	}
}
