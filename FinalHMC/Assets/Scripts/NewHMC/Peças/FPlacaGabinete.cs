using UnityEngine;
using System.Collections;

public class FPlacaGabinete : MonoBehaviour {

	public GameObject GabineteMotherBoard;
	public GameObject GabineteMotherBoardRAM;
	public GameObject GabineteMotherBoardVideo;
	public GameObject GabineteMotherBoardProcessador;
	public GameObject GabineteMotherBoardRAMProcessador;
	public GameObject GabineteMotherBoardRAMVideo;
	public GameObject GabineteMotherBoardProcessadorVideo;
	public GameObject GabineteMotherBoardRAMPRocessadorVideo;
	public GameObject GabineteMotherBoardRAM2Processador;
	public GameObject GabineteMotherBoardRAM2Video;
	public GameObject GabineteMotherBoardRAM2ProcessadorVideo;
	public GameObject GabineteMotherBoardRAM2;

	public GameObject GabineteCompletoRAM1Defeito;
	public GameObject GabineteCompletoDefeito;
	public GameObject GabineteMotherBoardRAM2Defeito;
	public GameObject GabineteMotherBoardRAM2ProcessadorDefeito;
	public GameObject GabineteMotherBoardRAM2VideoDefeito;
	public GameObject GabineteMotherBoardRAMDefeito;
	public GameObject GabineteMotherBoardRAMProcessadorDefeito;
	public GameObject GabineteMotherBoardRAMVideoDefeito;

	
	GameObject Gabinete;
	void Update () {
		Gabinete = GameObject.FindWithTag ("Gabinete");
		if (Vector3.Distance (Gabinete.transform.position, transform.position) < 5)
		{
			if (gameObject.tag == "MotherBoard") 
			{
				Instantiate (GabineteMotherBoard);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoard"));
			}

			if (gameObject.tag == "MotherBoardRAM") 
			{
				Instantiate (GabineteMotherBoardRAM);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAM"));
			}

			if (gameObject.tag == "MotherBoardVideo") 
			{
				Instantiate (GabineteMotherBoardVideo);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardVideo"));
			}

			if (gameObject.tag == "MotherBoardProcessador") 
			{
				Instantiate (GabineteMotherBoardProcessador);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
			}

			if (gameObject.tag == "MotherBoardRAMProcessador") 
			{
				Instantiate (GabineteMotherBoardRAMProcessador);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
			}

			if (gameObject.tag == "MotherBoardRAMVideo") 
			{
				Instantiate (GabineteMotherBoardRAMVideo);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
			}

			if (gameObject.tag == "MotherBoardProcessadorVideo") 
			{
				Instantiate (GabineteMotherBoardProcessadorVideo);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
			}

			if (gameObject.tag == "MotherBoardRAM2") 
			{
				Instantiate (GabineteMotherBoardRAM2);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
			}

			if (gameObject.tag == "MotherBoardRAMPRocessadorVideo") 
			{
				Instantiate (GabineteMotherBoardRAMPRocessadorVideo);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
			}

			if (gameObject.tag == "MotherBoardRAM2Processador") 
			{
				Instantiate (GabineteMotherBoardRAM2Processador);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
			}

			if (gameObject.tag == "MotherBoardRAM2Video") 
			{
				Instantiate (GabineteMotherBoardRAM2Video);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAM2Video"));
			}

			if (gameObject.tag == "MotherBoardRAM2ProcessadorVideo") 
			{
				Instantiate (GabineteMotherBoardRAM2ProcessadorVideo);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"));
			}


			//GABINETE DEFEITO

			if (gameObject.tag == "MotherBoardRAMProcessadorVideoDefeito") 
			{
				Instantiate (GabineteCompletoRAM1Defeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito"));
			}

			if (gameObject.tag == "MotherBoardRAM2ProcessadorVideoDefeito") 
			{
				Instantiate (GabineteCompletoDefeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito"));
			}

			if (gameObject.tag == "MotherBoardRAM2Defeito") 
			{
				Instantiate (GabineteMotherBoardRAM2Defeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito"));
			}

			if (gameObject.tag == "MotherBoardRAM2ProcessadorDefeito") 
			{
				Instantiate (GabineteMotherBoardRAM2ProcessadorDefeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorDefeito"));
			}

			if (gameObject.tag == "MotherBoardRAM2VideoDefeito") 
			{
				Instantiate (GabineteMotherBoardRAM2VideoDefeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAM2VideoDefeito"));
			}

			if (gameObject.tag == "MotherBoardRAMDefeito") 
			{
				Instantiate (GabineteMotherBoardRAMDefeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAMDefeito"));
			}

			if (gameObject.tag == "MotherBoardRAMProcessadorDefeito") 
			{
				Instantiate (GabineteMotherBoardRAMProcessadorDefeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito"));
			}

			if (gameObject.tag == "MotherBoardRAMVideoDefeito") 
			{
				Instantiate (GabineteMotherBoardRAMVideoDefeito);
				Destroy (Gabinete);
				Destroy(GameObject.FindWithTag("MotherBoardRAMVideoDefeito"));
			}

		}
	}
}
