using UnityEngine;
using System.Collections;

public class FProcessador : MonoBehaviour {
    public GameObject MotherBoardProcessador;
    public GameObject MotherBoardRAMProcessador;
    public GameObject MotherBoardProcessadorVideo;
    public GameObject MotherboardRAM2Processador;
    public GameObject MotherBoardRAMProcessadorVideo;
    public GameObject MotherBoardRAM2ProcessadorVideo;

	public GameObject GabineteMotherBoardProcessador;
	public GameObject GabineteMotherBoardRAMProcessador;
	public GameObject GabineteMotherBoardProcessadorVideo;
	public GameObject GabineteMotherboardRAM2Processador;
	public GameObject GabineteMotherBoardRAMProcessadorVideo;
	public GameObject GabineteMotherBoardRAM2ProcessadorVideo;

    public GameObject GabineteMotherBoardProcessadorDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoDefeito;
    public GameObject GabineteMotherboardRAM2ProcessadorDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoDefeito;

    public GameObject MotherBoardRAMProcessadorDefeito;
	public GameObject MotherboardRAM2ProcessadorDefeito;
	public GameObject MotherBoardRAMProcessadorVideoDefeito;
	public GameObject MotherBoardRAM2ProcessadorVideoDefeito;

    public GameObject GabineteMotherBoardProcessadorFonte;
    public GameObject GabineteMotherBoardProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAMProcessadorFonte;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonte;

    public GameObject GabineteMotherBoardProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteDefeito;

    public GameObject GabineteCompleto1RAMHD;
    public GameObject GabineteCompletoHD;
    public GameObject GabineteMotherBoardProcessadorHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorHD;
    public GameObject GabineteMotherBoardRAMProcessadorHD;
    public GameObject GabineteMotherBoardVideoProcessadorHD;

    public GameObject GabineteCompleto1RAMHDDefeito;
    public GameObject GabineteCompletoHDDefeito;
    public GameObject GabineteMotherBoardProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorHDDefeito;
    public GameObject GabineteMotherBoardVideoProcessadorHDDefeito;

    public GameObject GabineteMotherBoardProcessadorFonteHD;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHD;

    public GameObject GabineteMotherBoardProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito;

    GameObject Processador;

	void Update () {
        Processador = GameObject.FindWithTag("Processador");
        try
        {
            if (Vector3.Distance(Processador.transform.position, transform.position) < 4)
            {
                if (gameObject.tag == "MotherBoard")
                {
                    Instantiate(MotherBoardProcessador);    
                    Destroy(GameObject.FindWithTag("MotherBoard"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "MotherBoardRAM")
                {
                    Instantiate(MotherBoardRAMProcessador);
                    Destroy(GameObject.FindWithTag("MotherBoardRAM"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "MotherBoardVideo")
                {
                    Instantiate(MotherBoardProcessadorVideo);
                    Destroy(GameObject.FindWithTag("MotherBoardVideo"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "MotherBoardRAM2")
                {
                    Instantiate(MotherboardRAM2Processador);
                    Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "MotherBoardRAMVideo")
                {
                    Instantiate(MotherBoardRAMProcessadorVideo);
                    Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "MotherBoardRAM2Video")
                {
                    Instantiate(MotherBoardRAM2ProcessadorVideo);
                    Destroy(GameObject.FindWithTag("MotherBoardRAM2Video"));
                    Destroy(Processador);
                }

				//DEFEITO 



			

				if (gameObject.tag == "MotherBoardRAMDefeito")
				{
					Instantiate(MotherBoardRAMProcessadorDefeito);
					Destroy(GameObject.FindWithTag("MotherBoardRAMDefeito"));
					Destroy(Processador);
				}


				if (gameObject.tag == "MotherBoardRAM2Defeito")
				{
					Instantiate(MotherboardRAM2ProcessadorDefeito);
					Destroy(GameObject.FindWithTag("MotherBoardRAM2Defeito"));
					Destroy(Processador);
				}

				if (gameObject.tag == "MotherBoardRAMVideoDefeito")
				{
					Instantiate(MotherBoardRAMProcessadorVideoDefeito);
					Destroy(GameObject.FindWithTag("MotherBoardRAMVideoDefeito"));
					Destroy(Processador);
				}

				if (gameObject.tag == "MotherBoardRAM2VideoDefeito")
				{
					Instantiate(MotherBoardRAM2ProcessadorVideoDefeito);
					Destroy(GameObject.FindWithTag("MotherBoardRAM2VideoDefeito"));
					Destroy(Processador);
				}


                //GABINETE
				if (gameObject.tag == "GabineteMotherBoard")
				{
					Instantiate(GabineteMotherBoardProcessador);    
					Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
					Destroy(Processador);
				}

				if (gameObject.tag == "GabineteMotherBoardRAM")
				{
					Instantiate(GabineteMotherBoardRAMProcessador);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
					Destroy(Processador);
				}

				if (gameObject.tag == "GabineteMotherBoardVideo")
				{
					Instantiate(GabineteMotherBoardProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
					Destroy(Processador);
				}

				if (gameObject.tag == "GabineteMotherBoardRAM2")
				{
					Instantiate(GabineteMotherboardRAM2Processador);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2"));
					Destroy(Processador);
				}

				if (gameObject.tag == "GabineteMotherBoardRAMVideo")
				{
					Instantiate(GabineteMotherBoardRAMProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
					Destroy(Processador);
				}

				if (gameObject.tag == "GabineteMotherBoardRAM2Video")
				{
					Instantiate(GabineteMotherBoardRAM2ProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Video"));
					Destroy(Processador);
				}

                //GABINETE DEFEITO ====================================================================

                if(gameObject.tag == "GabineteMotherBoardDefeito")

                {
                    Instantiate(GabineteMotherBoardProcessadorDefeito);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardDefeito"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorDefeito);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMDefeito"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardVideoDefeito")
                {
                    Instantiate(GabineteMotherBoardProcessadorVideoDefeito);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoDefeito"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2Defeito")
                {
                    Instantiate(GabineteMotherboardRAM2ProcessadorDefeito);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoDefeito")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoDefeito);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2VideoDefeito")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoDefeito);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoDefeito"));
                    Destroy(Processador);
                }


                //GABINETE FONTE =============================================================================

                if (gameObject.tag == "GabineteMotherBoardFonte")
                {
                    Instantiate(GabineteMotherBoardProcessadorFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonte"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2Fonte")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2VideoFonte")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonte")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonte"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonte")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardVideoFonte")
                {
                    Instantiate(GabineteMotherBoardProcessadorVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonte"));
                    Destroy(Processador);
                }


                //GABINETE FONTE DEFEITO=============================================================

                if (gameObject.tag == "GabineteMotherBoardFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAM2FonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAM2VideoFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardVideoFonteDefeito")
                {

                }

                //GABINETE HD ============================================================

                if(gameObject.tag == "GabineteMotherBoardHD")
                {
                    Instantiate(GabineteMotherBoardProcessadorHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardHD"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2HD")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2HD"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2VideoHD")
                {
                    Instantiate(GabineteCompletoHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMHD")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHD"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoHD")
                {
                    Instantiate(GabineteCompleto1RAMHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardVideoHD")
                {
                    Instantiate(GabineteMotherBoardVideoProcessadorHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoHD"));
                    Destroy(Processador);
                }

                //GABINETE HD DEFEITO ============================================================

                if (gameObject.tag == "GabineteMotherBoardHDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAM2HDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorHDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAMHDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAMVideoHDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardVideoHDDefeito")
                {

                }

                //GABINETE FONTE HD =========================================================

                if (gameObject.tag == "GabineteMotherBoardFonteHD")
                {
                    Instantiate(GabineteMotherBoardProcessadorFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteHD"));
                    Destroy(Processador);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2FonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD"));
                    Destroy(Processador);
                }


                if (gameObject.tag == "GabineteMotherBoardRAM2VideoFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD"));
                    Destroy(Processador);
                }


                if (gameObject.tag == "GabineteMotherBoardRAMFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD"));
                    Destroy(Processador);
                }


                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD"));
                    Destroy(Processador);
                }


                if (gameObject.tag == "GabineteMotherBoardVideoFonteHD")
                {
                    Instantiate(GabineteMotherBoardProcessadorVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD"));
                    Destroy(Processador);
                }


                //GABINETE FONTE HD DEFEITO =========================================================

                if (gameObject.tag == "GabineteMotherBoardFonteHDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAM2FonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardRAM2VideoFonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardRAMFonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardRAMVideoFonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardVideoFonteHDDefeito")
                {

                }

            }
        }
        catch (System.Exception)
        {
            
            throw;
        }
	}
}
