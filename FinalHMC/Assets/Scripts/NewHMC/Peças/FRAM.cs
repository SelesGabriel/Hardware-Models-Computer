using UnityEngine;
using System.Collections;

public class FRAM : MonoBehaviour {

    public GameObject MotherboardRAM;
    public GameObject MotherboardRAMVideo;
    public GameObject MotherboardRAMProcessador;
    public GameObject MotherboardRAMProcessadorVideo;
    public GameObject MotherboardRAM2;
    public GameObject MotherboardRAM2Processador;
    public GameObject MotherboardRAM2ProcessadorVideo;
    public GameObject MotherboardRAM2Video;

	public GameObject GabineteMotherboardRAM;
	public GameObject GabineteMotherboardRAMVideo;
	public GameObject GabineteMotherboardRAMProcessador;
	public GameObject GabineteMotherboardRAMProcessadorVideo;
	public GameObject GabineteMotherboardRAM2;
	public GameObject GabineteMotherboardRAM2Processador;
	public GameObject GabineteMotherboardRAM2ProcessadorVideo;
	public GameObject GabineteMotherboardRAM2Video;

    public GameObject GabineteMotherBoardRAMFonte;
    public GameObject GabineteMotherBoardRAMProcessadorFonte;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2Fonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2VideoFonte;
    public GameObject GabineteMotherBoardRAMVideoFonte;

    public GameObject GabineteMotherBoardRAMFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2FonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteDefeito;

    public GameObject GabineteCompletoHD;
    public GameObject GabineteMotherBoardRAMHD;
    public GameObject GabineteMotherBoardRAMProcessadorHD;
    public GameObject GabineteMotherBoardRAM2HD;
    public GameObject GabineteMotherBoardRAM2ProcessadorHD;
    public GameObject GabineteMotherBoardRAM2VideoHD;
    public GameObject GabineteMotherRAMVideoBoardHD;
    public GameObject GabineteCompleto1RAMHD;

    public GameObject GabineteCompletoHDDefeito;
    public GameObject GabineteMotherBoardRAMHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAM2HDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoHDDefeito;
    public GameObject GabineteMotherRAMVideoBoardHDDefeito;
    public GameObject GabineteCompleto1RAMHDDefeito;

    public GameObject GabineteMotherBoardRAM2FonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2VideoFonteHD;
    public GameObject GabineteMotherBoardRAMFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAMVideoFonteHD;

    public GameObject GabineteMotherBoardRAM2FonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteHDDefeito;

    public GameObject GabineteMotherBoardRAMVideoHD;
    public GameObject GabineteMotherBoardRAMVideoHDDefeito;

    GameObject RAM;

	void Update () {
        RAM = GameObject.FindWithTag("RAM");
        try
        {
            if (Vector3.Distance(RAM.transform.position, transform.position) < 4)
            {
                if (gameObject.tag == "MotherBoard")
                {
                    Instantiate(MotherboardRAM);
                    Destroy(GameObject.FindWithTag("MotherBoard"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardVideo")
                {
                    Instantiate(MotherboardRAMVideo);
                    Destroy(GameObject.FindWithTag("MotherBoardVideo"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardProcessador")
                {
                    Instantiate(MotherboardRAMProcessador);
                    Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardProcessadorVideo")
                {
                    Instantiate(MotherboardRAMProcessadorVideo);
                    Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardRAM")
                {
                    Instantiate(MotherboardRAM2);
                    Destroy(GameObject.FindWithTag("MotherBoardRAM"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardRAMProcessador")
                {
                    Instantiate(MotherboardRAM2Processador);
                    Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardRAMVideo")
                {
                    Instantiate(MotherboardRAM2Video);
                    Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardRAMPRocessadorVideo")
                {
                    Instantiate(MotherboardRAM2ProcessadorVideo);
                    Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
                    Destroy(RAM);
                }


				//GABINETE=====================================================================================
				if(gameObject.tag == "GabineteMotherBoard")
				{
					Instantiate(GabineteMotherboardRAM);
					Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
					Destroy(RAM);
				}

				if(gameObject.tag == "GabineteMotherBoardVideo")
				{
					Instantiate(GabineteMotherboardRAMVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
					Destroy(RAM);
				}

				if(gameObject.tag == "GabineteMotherBoardRAM")
				{
					Instantiate(GabineteMotherboardRAM2);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
					Destroy(RAM);
				}

				if(gameObject.tag == "GabineteMotherBoardProcessador")
				{
					Instantiate(GabineteMotherboardRAMProcessador);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
					Destroy(RAM);
				}

				if(gameObject.tag == "GabineteMotherBoardRAMVideo")
				{
					Instantiate(GabineteMotherboardRAM2Video);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
					Destroy(RAM);
				}

				if(gameObject.tag == "MotherBoardRAMProcessador")
				{
					Instantiate(GabineteMotherboardRAM2Processador);
					Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
					Destroy(RAM);
				}

				if(gameObject.tag == "GabineteMotherBoardProcessadorVideo")
				{
					Instantiate(GabineteMotherboardRAMProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"));
					Destroy(RAM);
				}

				if(gameObject.tag == "GabineteMotherBoardRAMProcessadorVideo")
				{
					Instantiate(GabineteMotherboardRAM2ProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideo"));
					Destroy(RAM);
				}

				if(gameObject.tag == "GabineteMotherBoardRAMProcessador"){
					Instantiate(GabineteMotherboardRAM2Processador);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
					Destroy(RAM);
				}
                /*
                //GABINETE DEFEITO================================================================================
                if (gameObject.tag == "GabineteMotherBoardDefeito")
                {
                    Instantiate(GabineteMotherboardRAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardDefeito"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "GabineteMotherBoardVideo")
                {
                    Instantiate(GabineteMotherboardRAMVideo);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM")
                {
                    Instantiate(GabineteMotherboardRAM2);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "GabineteMotherBoardProcessador")
                {
                    Instantiate(GabineteMotherboardRAMProcessador);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideo")
                {
                    Instantiate(GabineteMotherboardRAM2Video);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "MotherBoardRAMProcessador")
                {
                    Instantiate(GabineteMotherboardRAM2Processador);
                    Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorVideo")
                {
                    Instantiate(GabineteMotherboardRAMProcessadorVideo);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideo")
                {
                    Instantiate(GabineteMotherboardRAM2ProcessadorVideo);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideo"));
                    Destroy(RAM);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessador")
                {
                    Instantiate(GabineteMotherboardRAM2Processador);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
                    Destroy(RAM);
                }
                */


                //GABINETE COM FONTE=========================================================================

                if (gameObject.tag == "GabineteMotherBoardFonte")
                {
                    Instantiate(GabineteMotherBoardRAMFonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonte"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonte")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorFonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorVideoFonte")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonte")
                {
                    Instantiate(GabineteMotherBoardRAM2Fonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonte"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonte")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorFonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideoFonte")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonte")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoFonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoFonte")
                {
                    Instantiate(GabineteMotherBoardRAMVideoFonte);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonte"));
                }

                //GABINETE FONTE COM DEFEITO =====================================================

                if (gameObject.tag == "GabineteMotherBoardFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMFonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorFonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorVideoFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2FonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorFonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideoFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoFonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoFonteDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMVideoFonteDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonteDefeito"));
                }

                //GABINETE HD =================================================================

                if (gameObject.tag == "GabineteCompleto1RAMHD")
                {
                    Instantiate(GabineteCompletoHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteCompleto1RAMHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardHD")
                {
                    Instantiate(GabineteMotherBoardRAMHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorHD")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMHD")
                {
                    Instantiate(GabineteMotherBoardRAM2HD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorHD")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoHD")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoHD")
                {
                    Instantiate(GabineteMotherBoardRAMVideoHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoProcessadorHD")
                {
                    Instantiate(GabineteCompleto1RAMHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD"));
                }

                //GABINETE HD DEFEITO =================================================================

                if (gameObject.tag == "GabineteCompleto1RAMHDDefeito")
                {
                    Instantiate(GabineteCompletoHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2HDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMVideoHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoProcessadorHDDefeito")
                {
                    Instantiate(GabineteCompleto1RAMHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito"));
                }


                //GABINETE FONTE HD ===========================================

                if(gameObject.tag == "GabineteMotherBoardFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMFonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorFonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorVideoFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2FonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideoFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoFonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMVideoFonteHD);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD"));
                }

                //GABINETE FONTE HD DEFEITO ===========================================

                if (gameObject.tag == "GabineteMotherBoardFonteHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMFonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonteHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorFonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorVideoFonteHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonteHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2FonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonteHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonteHDDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoFonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHDDefeito"));
                }

                if (gameObject.tag == "GabineteMotherBoardVideoFonteHDDefeito")
                {Instantiate(GabineteMotherBoardRAMVideoFonteHDDefeito);
                    Destroy(RAM);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonteHDDefeito"));
                }


            }
        }
        catch (System.Exception)
        {
            
            
        }
	}
}
