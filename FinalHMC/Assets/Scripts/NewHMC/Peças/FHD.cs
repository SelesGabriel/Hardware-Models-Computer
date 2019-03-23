using UnityEngine;
using System.Collections;

public class FHD : MonoBehaviour {

    public GameObject GabineteHD;
    public GameObject GabineteCompletoRAM1HD;
    public GameObject GabineteCompletoHD;
    public GameObject GabineteMotherBoardHD;
    public GameObject GabineteMotherBoardProcessadorHD;
    public GameObject GabineteMotherBoardRAM2HD;
    public GameObject GabineteMotherBoardRAM2ProcessadorHD;
    public GameObject GabineteMotherBoardRAM2VideoHD;
    public GameObject GabineteMotherBoardRAMHD;
    public GameObject GabineteMotherBoardRAMProcessadorHD;
    public GameObject GabineteMotherBoardRAMVideoHD;
    public GameObject GabineteMotherBoardVideoHD;
    public GameObject GabineteMotherBoardVideoProcessadorHD;

    public GameObject GabineteHDDefeito;
    public GameObject GabineteCompletoRAM1HDDefeito;
    public GameObject GabineteCompletoHDDefeito;
    public GameObject GabineteMotherBoardHDDefeito;
    public GameObject GabineteMotherBoardProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAM2HDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoHDDefeito;
    public GameObject GabineteMotherBoardRAMHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoHDDefeito;
    public GameObject GabineteMotherBoardVideoHDDefeito;
    public GameObject GabineteMotherBoardVideoProcessadorHDDefeito;

    public GameObject GabineteFonteHD;
    public GameObject GabineteMotherBoardFonteHD;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2FonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2VideoFonteHD;
    public GameObject GabineteMotherBoardRAMFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAMVideoFonteHD;
    public GameObject GabineteMotherBoardVideoFonteHD;

    public GameObject GabineteFonteHDDefeito;
    public GameObject GabineteMotherBoardFonteHDDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2FonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardVideoFonteHDDefeito;

    public GameObject GabineteMotherBoardProcessadorFonteHD;
    public GameObject GabineteMotherBoardProcessadorFonteHDDefeito;


    GameObject HD;
	void Update () {
        HD = GameObject.FindWithTag("HD");
	    if(Vector3.Distance(HD.transform.position, transform.position) < 4)
        {
            if(gameObject.tag == "Gabinete")
            {
                Instantiate(GabineteHD);
                Destroy(GameObject.FindWithTag("Gabinete"));
                Destroy(HD);
            }

            if(gameObject.tag == "GabineteCompleto")
            {
                Instantiate(GabineteCompletoHD);
                Destroy(GameObject.FindWithTag("GabineteCompleto"));
                Destroy(HD);
            }

            if(gameObject.tag == "GabineteCompletoRAM1")
            {
                Instantiate(GabineteCompletoRAM1HD);
                Destroy(GameObject.FindWithTag("GabineteCompletoRAM1"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoard")
            {
                Instantiate(GabineteMotherBoardHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessador")
            {
                Instantiate(GabineteMotherBoardProcessadorHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM")
            {
                Instantiate(GabineteMotherBoardRAMHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2")
            {
                Instantiate(GabineteMotherBoardRAM2HD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2Processador")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2Video")
            {
                Instantiate(GabineteMotherBoardRAM2VideoHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Video"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessador")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideo")
            {
                Instantiate(GabineteMotherBoardRAMVideoHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardVideo")
            {
                Instantiate(GabineteMotherBoardVideoHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardVideoProcessadorHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"));
                Destroy(HD);
            }

            //DEFEITO

            if (gameObject.tag == "GabineteCompletoDefeito")
            {
                Instantiate(GabineteCompletoHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteCompletoDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteCompletoRAM1Defeito")
            {
                Instantiate(GabineteCompletoRAM1HDDefeito);
                Destroy(GameObject.FindWithTag("GabineteCompletoRAM1Defeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardDefeito")
            {
                Instantiate(GabineteMotherBoardHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMDefeito")
            {
                Instantiate(GabineteMotherBoardRAMHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2Defeito")
            {
                Instantiate(GabineteMotherBoardRAM2HDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2VideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2VideoHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMVideoHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardVideoDefeito")
            {
                Instantiate(GabineteMotherBoardVideoHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardVideoProcessadorHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoDefeito"));
                Destroy(HD);
            }


            //=============================================================================================

            if(gameObject.tag == "GabineteFonte")
            {
                Instantiate(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("GabineteFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardFonte")
            {
                Instantiate(GabineteMotherBoardFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorFonte")
            {
                Instantiate(GabineteMotherBoardProcessadorFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorVideoFonte")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2Fonte")
            {
                Instantiate(GabineteMotherBoardRAM2FonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorFonte")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorVideoFonte")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2VideoFonte")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMFonte")
            {
                Instantiate(GabineteMotherBoardRAMFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonte")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideoFonte")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoFonte")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardVideoFonte")
            {
                Instantiate(GabineteMotherBoardVideoFonteHD);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonte"));
                Destroy(HD);
            }

            //====================================================================================================


            if (gameObject.tag == "GabineteFonteDefeito")
            {
                Instantiate(GabineteFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardFonteDefeito")
            {
                Instantiate(GabineteMotherBoardFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorFonteDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorVideoFonteDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2FonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2FonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2FonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorFonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2VideoFonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2VideoFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMFonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAMFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorFonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorVideoFonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoFonteDefeito")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteDefeito"));
                Destroy(HD);
            }

            if (gameObject.tag == "GabineteMotherBoardVideoFonteDefeito")
            {
                Instantiate(GabineteMotherBoardVideoFonteHDDefeito);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonteDefeito"));
                Destroy(HD);
            }
        }
	}
}
