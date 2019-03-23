using UnityEngine;
using System.Collections;

public class Lixo : MonoBehaviour {

    GameObject Lata;
    GameObject RAM;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Lata = GameObject.Find("LataLixo");

        RAM = GameObject.FindWithTag("RAM");

        if(Vector3.Distance(Lata.transform.position, transform.position) < 5)
        {
            

			if (GameObject.FindWithTag("Gabinete"))
			{
				Destroy(GameObject.FindWithTag("Gabinete"));
			}

			if (GameObject.FindWithTag("HD"))
			{
				Destroy(GameObject.FindWithTag("HD"));
			}

			if (GameObject.FindWithTag("HardDiskDefeito"))
			{
				Destroy(GameObject.FindWithTag("HardDiskDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoard"))
			{
				Destroy(GameObject.FindWithTag("MotherBoard"));
			}

			if (GameObject.FindWithTag("MotherBoardDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardDefeito"));
			}

			if (GameObject.FindWithTag("VideoBoard"))
			{
				Destroy(GameObject.FindWithTag("VideoBoard"));
			}

			if (GameObject.FindWithTag("VideoBoardDefeito"))
			{
				Destroy(GameObject.FindWithTag("VideoBoardDefeito"));
			}

			if (GameObject.FindWithTag("Processador"))
			{
				Destroy(GameObject.FindWithTag("Processador"));
			}

			if (GameObject.FindWithTag("ProcessadorDefeito"))
			{
				Destroy(GameObject.FindWithTag("ProcessadorDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardProcessador"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
			}

			if (GameObject.FindWithTag("MotherBoardProcessadorVideo"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2Defeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2Defeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2Defeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2Defeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2Processador"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAm2Video"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAm2Video"));
			}

			if (GameObject.FindWithTag("MotherBoardRAM2VideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAM2VideoDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAMDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAMDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAMProcessador"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
			}

			if (GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
			}

			if (GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardRAMVideo"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
			}

			if (GameObject.FindWithTag("MotherBoardRAMVideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardRAMVideoDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardVideo"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardVideo"));
			}

			if (GameObject.FindWithTag("GabineteCompleto"))
			{
				Destroy(GameObject.FindWithTag("GabineteCompleto"));
			}

			if (GameObject.FindWithTag("GabineteCompletoRAM1"))
			{
				Destroy(GameObject.FindWithTag("GabineteCompletoRAM1"));
			}

			if (GameObject.FindWithTag("GabineteCompletoDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteCompletoDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoard"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardProcessador"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAM"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAM2"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito"))
			{
						Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAM2Video"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Video"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAM2VideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAMDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAMVideo"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito"));
			}
			if (GameObject.FindWithTag("GabineteMotherBoardVideo"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardVideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoDefeito"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardVideoProcessador"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessador"));
			}

			if (GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorDefeito"))
			{
				Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorDefeito"));
			}

			if (GameObject.FindWithTag("MotherBoardVideoDefeito"))
			{
				Destroy(GameObject.FindWithTag("MotherBoardVideoDefeito"));
			}
        }
	}
}
