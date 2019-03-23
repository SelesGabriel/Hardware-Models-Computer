using UnityEngine;
using System.Collections;

public class FRAMDefeito : MonoBehaviour {

	public GameObject MotherboardRAMDefeito;
	public GameObject MotherboardRAMVideoDefeito;
	public GameObject MotherboardRAMProcessadorDefeito;
	public GameObject MotherboardRAMProcessadorVideoDefeito;
	public GameObject MotherboardRAM2Defeito;
	public GameObject MotherboardRAM2ProcessadorDefeito;
	public GameObject MotherboardRAM2ProcessadorVideoDefeito;
	public GameObject MotherboardRAM2VideoDefeito;

	public GameObject GabineteMotherboardRAMDefeito;
	public GameObject GabineteMotherboardRAMVideoDefeito;
	public GameObject GabineteMotherboardRAMProcessadorDefeito;
	public GameObject GabineteMotherboardRAMProcessadorVideoDefeito;
	public GameObject GabineteMotherboardRAM2Defeito;
	public GameObject GabineteMotherboardRAM2ProcessadorDefeito;
	public GameObject GabineteMotherboardRAM2ProcessadorVideoDefeito;
	public GameObject GabineteMotherboardRAM2VideoDefeito;

	GameObject RAMDefeito;

	void Update () {
		RAMDefeito = GameObject.FindWithTag ("RAMDefeito");
		try {
			if (Vector3.Distance (RAMDefeito.transform.position, transform.position) < 4) {
				if (gameObject.tag == "MotherBoard") {
					Instantiate (MotherboardRAMDefeito);
					Destroy (GameObject.FindWithTag ("MotherBoard"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "MotherBoardVideo") {
					Instantiate (MotherboardRAMVideoDefeito);
					Destroy (GameObject.FindWithTag ("MotherBoardVideo"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "MotherBoardProcessador") {
					Instantiate (MotherboardRAMProcessadorDefeito);
					Destroy (GameObject.FindWithTag ("MotherBoardProcessador"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "MotherBoardProcessadorVideo") {
					Instantiate (MotherboardRAMProcessadorVideoDefeito);
					Destroy (GameObject.FindWithTag ("MotherBoardProcessadorVideo"));
					Destroy (RAMDefeito);
				}

				

				if (gameObject.tag == "MotherBoardRAMProcessador") {
					Instantiate (MotherboardRAM2ProcessadorDefeito);
					Destroy (GameObject.FindWithTag ("MotherBoardRAMProcessador"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "MotherBoardRAMVideo") {
					Instantiate (MotherboardRAM2VideoDefeito);
					Destroy (GameObject.FindWithTag ("MotherBoardRAMVideo"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "MotherBoardRAMPRocessadorVideo") {
					Instantiate (MotherboardRAM2ProcessadorVideoDefeito);
					Destroy (GameObject.FindWithTag ("MotherBoardRAMPRocessadorVideo"));
					Destroy (RAMDefeito);
				}


				//GABINETE
				if (gameObject.tag == "GabineteMotherBoard") {
					Instantiate (GabineteMotherboardRAMDefeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoard"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "GabineteMotherBoardVideo") {
					Instantiate (GabineteMotherboardRAMVideoDefeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoardVideo"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "GabineteMotherBoardRAM") {
					Instantiate (GabineteMotherboardRAM2Defeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoardRAM"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "GabineteMotherBoardProcessador") {
					Instantiate (GabineteMotherboardRAMProcessadorDefeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoardProcessador"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "GabineteMotherBoardRAMVideo") {
					Instantiate (GabineteMotherboardRAM2VideoDefeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoardRAMVideo"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "GabineteMotherBoardRAMProcessador") {
					Instantiate (GabineteMotherboardRAM2ProcessadorDefeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoardRAMProcessador"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "GabineteMotherBoardProcessadorVideo") {
					Instantiate (GabineteMotherboardRAMProcessadorVideoDefeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoardProcessadorVideo"));
					Destroy (RAMDefeito);
				}

				if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideo") {
					Instantiate (GabineteMotherboardRAM2ProcessadorVideoDefeito);
					Destroy (GameObject.FindWithTag ("GabineteMotherBoardRAMProcessadorVideo"));
					Destroy (RAMDefeito);
				}
			}
		} catch (System.Exception) {
		}
	}
}
