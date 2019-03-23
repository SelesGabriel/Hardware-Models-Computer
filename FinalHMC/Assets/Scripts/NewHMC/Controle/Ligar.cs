using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Ligar : MonoBehaviour {

	public GameObject texto;

	void Start(){
		
		GameObject.FindWithTag ("TelaPreta").SetActive (true);
		GameObject.FindWithTag ("TelaAzul").SetActive (false);

	}

	public void btnLigar(){
		if (GameObject.FindWithTag ("GabineteMotherBoardRAM2ProcessadorFonteHD")) {
			GameObject.FindWithTag ("TelaPreta").SetActive (false);

		} 

		else if (GameObject.FindWithTag ("GabineteMotherBoardRAMProcessadorFonteHD")) {
			GameObject.FindWithTag ("TelaPreta").SetActive (false);

		} 

		else if (GameObject.FindWithTag ("GabineteMotherBoardRAMProcessadorVideoFonteHD")) {
			GameObject.FindWithTag ("TelaPreta").SetActive (false);

		} 

		else if (GameObject.FindWithTag ("GabineteMotherBoardRAM2ProcessadorVideoFonteHD")) {
			GameObject.FindWithTag ("TelaPreta").SetActive (false);

		} 

		else {
			texto.SetActive (true);
			StartCoroutine ("Esperar");
		}
	}

	IEnumerator Esperar(){
		yield return new WaitForSeconds (3.0f);
		texto.SetActive (false);
       
    }
}
