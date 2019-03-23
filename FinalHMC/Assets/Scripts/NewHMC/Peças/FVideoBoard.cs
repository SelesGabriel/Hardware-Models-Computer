using UnityEngine;
using System.Collections;

public class FVideoBoard : MonoBehaviour {

    public GameObject MotherBoardVideo;
    public GameObject MotherBoardRAMVideo;
    public GameObject MotherBoardRAM2Video;
    public GameObject MotherBoardProcessadorVideo;
    public GameObject MotherBoardRAMProcessadorVideo;
    public GameObject MotherBoardRAM2ProcessadorVideo;

	public GameObject GabineteMotherBoardVideo;
	public GameObject GabineteMotherBoardRAMVideo;
	public GameObject GabineteMotherBoardRAM2Video;
	public GameObject GabineteMotherBoardProcessadorVideo;
	public GameObject GabineteMotherBoardRAMProcessadorVideo;
	public GameObject GabineteMotherBoardRAM2ProcessadorVideo;
  

    //PEÇAS COM DEFEITO

    public GameObject MotherBoardRAMVideoDefeito;
    public GameObject MotherBoardRAM2VideoDefeito;
    public GameObject MotherBoardProcessadorVideoDefeito;
    public GameObject MotherBoardRAMProcessadorVideoDefeito;
    public GameObject MotherBoardRAM2ProcessadorVideoDefeito;
    //===============================================
    public GameObject GabineteMotherBoardRAMVideoDefeito;
    public GameObject GabineteMotherBoardRAM2VideoDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoDefeito;
    //===============================================
    public GameObject GabineteMotherBoardProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2VideoFonte;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAMVideoFonte;
    public GameObject GabineteMotherBoardVideoFonte;
    //===============================================
    public GameObject GabineteMotherBoardProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteDefeito;
    public GameObject GabineteMotherBoardVideoFonteDefeito;
    //===============================================
    public GameObject GabineteCompleto1RAMHD;
    public GameObject GabineteCompletoHD;
    public GameObject GabineteMotherBoardRAM2VideoHD;
    public GameObject GabineteMotherBoardRAMVideoHD;
    public GameObject GabineteMotherBoardVideoHD;
    public GameObject GabineteMotherBoardVideoProcessadorHD;
    //===============================================
    public GameObject GabineteCompleto1RAMHDDefeito;
    public GameObject GabineteCompletoHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoHDDefeito;
    public GameObject GabineteMotherBoardVideoHDDefeito;
    public GameObject GabineteMotherBoardVideoProcessadorHDDefeito;
    //===============================================
    public GameObject GabineteMotherBoardProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2VideoFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAMVideoFonteHD;
    public GameObject GabineteMotherBoardVideoFonteHD;
    //===============================================
    public GameObject GabineteMotherBoardProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardVideoFonteHDDefeito;

    GameObject VideoBoard;
	void Update () {
        VideoBoard = GameObject.FindWithTag("VideoBoard");

        try
        {
            if (Vector3.Distance(VideoBoard.transform.position, transform.position) < 4)
            {
				//GABINETE

				if (gameObject.tag == "GabineteMotherBoard")
                {
					Instantiate(GabineteMotherBoardVideo);
                    Destroy(VideoBoard);
					Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
                }

				if (gameObject.tag == "GabineteMotherBoardRAM")
                {
					Instantiate(GabineteMotherBoardRAMVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
                    Destroy(VideoBoard);
                }

				if (gameObject.tag == "GabineteMotherBoardRAM2")
                {
					Instantiate(GabineteMotherBoardRAM2Video);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2"));
                    Destroy(VideoBoard);
                }

				if (gameObject.tag == "GabineteMotherBoardProcessador")
                {
					Instantiate(GabineteMotherBoardProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
                    Destroy(VideoBoard);
                }

				if (gameObject.tag == "GabineteMotherBoardRAMProcessador")
                {
					Instantiate(GabineteMotherBoardRAMProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
                    Destroy(VideoBoard);
                }

				if (gameObject.tag == "GabineteMotherBoardRAM2Processador")
                {
					Instantiate(GabineteMotherBoardRAM2ProcessadorVideo);
					Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"));
                    Destroy(VideoBoard);
                }

                //MOTHERBOARD

				if (gameObject.tag == "MotherBoard")
				{
					Instantiate(MotherBoardVideo);
					Destroy(VideoBoard);
					Destroy(GameObject.FindWithTag("MotherBoard"));
				}

				if (gameObject.tag == "MotherBoardRAM")
				{
					Instantiate(MotherBoardRAMVideo);
					Destroy(GameObject.FindWithTag("MotherBoardRAM"));
					Destroy(VideoBoard);
				}

				if (gameObject.tag == "MotherBoardRAM2")
				{
					Instantiate(MotherBoardRAM2Video);
					Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
					Destroy(VideoBoard);
				}

				if (gameObject.tag == "MotherBoardProcessador")
				{
					Instantiate(MotherBoardProcessadorVideo);
					Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
					Destroy(VideoBoard);
				}

				if (gameObject.tag == "MotherBoardRAMProcessador")
				{
					Instantiate(MotherBoardRAMProcessadorVideo);
					Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
					Destroy(VideoBoard);
				}

				if (gameObject.tag == "MotherBoardRAM2Processador")
				{
					Instantiate(MotherBoardRAM2ProcessadorVideo);
					Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
					Destroy(VideoBoard);
				}
               

                //RAM DEFEITO

                if(gameObject.tag == "MotherBoardRAMDefeito")
                {
                    Instantiate(MotherBoardRAMVideoDefeito);
                    Destroy(GameObject.FindWithTag("MotherBoardRAMDefeito"));
                    Destroy(VideoBoard);
                }
                
                if(gameObject.tag == "MotherBoardRAMProcessadorDefeito")
                {
                    Instantiate(MotherBoardRAMProcessadorVideoDefeito);
                    Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito"));
                    Destroy(VideoBoard);
                }

                if(gameObject.tag == "MotherBoardRAM2Defeito")
                {
                    Instantiate(MotherBoardRAM2VideoDefeito);
                    Destroy(GameObject.FindWithTag("MotherBoardRAM2Defeito"));
                    Destroy(VideoBoard);
                }

                if(gameObject.tag == "MotherBoardRAM2ProcessadorDefeito")
                {
                    Instantiate(MotherBoardRAM2ProcessadorVideoDefeito);
                    Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito"));
                    Destroy(VideoBoard);
                }

                //GABINETE COM FONTE ======================================================

                if(gameObject.tag == "GabineteMotherBoardFonte")
                {
                    Instantiate(GabineteMotherBoardVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonte"));
                    Destroy(VideoBoard);
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonte")
                {
                    Instantiate(GabineteMotherBoardProcessadorVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte"));
                    Destroy(VideoBoard);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2Fonte")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte"));
                    Destroy(VideoBoard);
                }

                if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorFonte")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte"));
                    Destroy(VideoBoard);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonte")
                {
                    Instantiate(GabineteMotherBoardRAMVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonte"));
                    Destroy(VideoBoard);
                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonte")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonte);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte"));
                    Destroy(VideoBoard);
                }

                //GABINETE COM FONTE DEFEITO ============================

                if (gameObject.tag == "GabineteMotherBoardFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAM2FonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAMFonteDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonteDefeito")
                {

                }


                //GABINETE HD =====================================================================

                if(gameObject.tag == "GabineteMotherBoardHD")
                {
                    Instantiate(GabineteMotherBoardVideoHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardHD"));
                    Destroy(VideoBoard);
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorHD")
                {
                    Instantiate(GabineteMotherBoardVideoProcessadorHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorHD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAM2HD")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2HD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorHD")
                {
                    Instantiate(GabineteCompletoHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAMHD")
                {
                    Instantiate(GabineteMotherBoardRAMVideoHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorHD")
                {
                    Instantiate(GabineteCompleto1RAMHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD"));
                    Destroy(VideoBoard);
                }

                //GABINETE HD DEFEITO =====================================================================

                if (gameObject.tag == "GabineteMotherBoardHDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorHDDefeito")
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


                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorHDDefeito")
                {

                }

                //GABINETE FONTE HD =========================================================

                if(gameObject.tag == "GabineteMotherBoardFonteHD")
                {
                    Instantiate(GabineteMotherBoardVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteHD"));
                    Destroy(VideoBoard);
                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonteHD")
                {
                    Instantiate(GabineteMotherBoardProcessadorVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAM2FonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2VideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAMFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD"));
                    Destroy(VideoBoard);
                }


                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonteHD")
                {
                    Instantiate(GabineteMotherBoardRAMProcessadorVideoFonteHD);
                    Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD"));
                    Destroy(VideoBoard);
                }

                //GABINETE FONTE HD DEFEITO =========================================================

                if (gameObject.tag == "GabineteMotherBoardFonteHDDefeito")
                {

                }

                if (gameObject.tag == "GabineteMotherBoardProcessadorFonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardRAM2FonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorFonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardRAMFonteHDDefeito")
                {

                }


                if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonteHDDefeito")
                {

                }


            }
        }
        catch (System.Exception)
        {
            
            
        }
	}
}
