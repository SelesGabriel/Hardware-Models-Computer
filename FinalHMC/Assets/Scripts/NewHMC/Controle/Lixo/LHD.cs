using UnityEngine;
using System.Collections;

public class LHD : MonoBehaviour {

	GameObject Lata;

	void Update () {
		Lata = GameObject.Find ("LataLixo");



		if (Vector3.Distance (Lata.transform.position, transform.position) < 5) {
			if (GameObject.FindWithTag ("HD")) {
				Destroy (GameObject.FindWithTag ("HD"));
			}
		}
	}
}
