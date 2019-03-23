using UnityEngine;
using System.Collections;

public class FFonte : MonoBehaviour {

    public GameObject GabineteFonte;
    public GameObject GabineteMotherBoardFonte;
    public GameObject GabineteMotherBoardProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2Fonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2VideoFonte;
    public GameObject GabineteMotherBoardRAMFonte;
    public GameObject GabineteMotherBoardRAMProcessadorFonte;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAMVideoFonte;
    public GameObject GabineteMotherBoardVideoFonte;

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


    public GameObject GabineteMotherBoardProcessadorFonte;

    public GameObject GabineteMotherBoardProcessadorFonteDefeito;

    public GameObject GabineteFonteDefeito;
    public GameObject GabineteMotherBoardFonteDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2FonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteDefeito;
    public GameObject GabineteMotherBoardRAMFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteDefeito;
    public GameObject GabineteMotherBoardVideoFonteDefeito;

    public GameObject GabineteMotherBoardProcessadorFonteHD;
    public GameObject GabineteMotherBoardProcessadorFonteHDDefeito;

    GameObject Fonte;
	void Update () {
        Fonte = GameObject.FindWithTag("Fonte");
        if(Vector3.Distance(Fonte.transform.position, transform.position) < 4)
        {
            if(gameObject.tag == "Gabinete")
            {
                Instantiate(GabineteFonte);
                Destroy(GameObject.FindWithTag("Gabinete"));
                Destroy(Fonte);
            }

            if (gameObject.tag == "GabineteCompleto")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompleto"));
            }

            if (gameObject.tag == "GabineteCompletoRAM1")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompletoRAM1"));
            }

            if (gameObject.tag == "GabineteMotherBoard")
            {
                Instantiate(GabineteMotherBoardFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
            }

            if (gameObject.tag == "GabineteMotherBoardProcessador")
            {
                Instantiate(GabineteMotherBoardProcessadorFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAM")
            {
                Instantiate(GabineteMotherBoardRAMFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2")
            {
                Instantiate(GabineteMotherBoardRAM2Fonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2Processador")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideo")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessador")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideo")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
            }

            if (gameObject.tag == "GabineteMotherBoardVideo")
            {
                Instantiate(GabineteMotherBoardVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"));
            }

            //PULA 

            if (gameObject.tag == "GabineteCompletoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompletoDefeito"));
            }

            if (gameObject.tag == "GabineteCompletoRAM1Defeito")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorVideoFonte);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompletoRAM1Defeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardDefeito")
            {
                Instantiate(GabineteMotherBoardFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAMDefeito")
            {
                Instantiate(GabineteMotherBoardRAMFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2Defeito")
            {
                Instantiate(GabineteMotherBoardRAM2FonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardVideoDefeito")
            {
                Instantiate(GabineteMotherBoardVideoFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoFonteDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoDefeito"));
            }

            //PULA =================================================================================================

            if (gameObject.tag == "GabineteHD")
            {
                Instantiate(GabineteFonteHD);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteHD"));
            }

            if (gameObject.tag == "GabineteCompletoHD")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHD);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompletoHD"));
            }

            if (gameObject.tag == "GabineteCompleto1RAMHD")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoFonteHD);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompleto1RAMHD"));
            }

            if (gameObject.tag == "GabineteMotherBoardHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardHD"));
                Instantiate(GabineteMotherBoardFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorHD"));
                Instantiate(GabineteMotherBoardProcessadorFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHD"));
                Instantiate(GabineteMotherBoardRAMFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2HD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2HD"));
                Instantiate(GabineteMotherBoardRAM2FonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD"));
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2VideoHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD"));
                Instantiate(GabineteMotherBoardRAM2VideoFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD"));
                Instantiate(GabineteMotherBoardRAMProcessadorFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD"));
                Instantiate(GabineteMotherBoardRAMVideoFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardVideoHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoHD"));
                Instantiate(GabineteMotherBoardVideoFonteHD);
            }

            if (gameObject.tag == "GabineteMotherBoardVideoProcessadorHD")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD"));
                Instantiate(GabineteMotherBoardProcessadorVideoFonteHD);
            }


            //PULA ===========================================================================================

            if (gameObject.tag == "GabineteHDDefeito")
            {
                Instantiate(GabineteFonteHDDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteHDDefeito"));
            }

            if (gameObject.tag == "GabineteCompletoHDDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHDDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompletoHDDefeito"));
            }

            if (gameObject.tag == "GabineteCompleto1RAMHDDefeito")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoFonteHDDefeito);
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito"));
            }

            if (gameObject.tag == "GabineteMotherBoardHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardHDDefeito"));
                Instantiate(GabineteMotherBoardFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardProcessadorHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorHDDefeito"));
                Instantiate(GabineteMotherBoardProcessadorFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHDDefeito"));
                Instantiate(GabineteMotherBoardRAMFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2HDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2HDDefeito"));
                Instantiate(GabineteMotherBoardRAM2FonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardRAM2ProcessadorHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHDDefeito"));
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito"));
                Instantiate(GabineteMotherBoardRAMVideoFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMProcessadorHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHDDefeito"));
                Instantiate(GabineteMotherBoardRAMProcessadorFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardRAMVideoHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito"));
                Instantiate(GabineteMotherBoardRAMVideoFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardVideoHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoHDDefeito"));
                Instantiate(GabineteMotherBoardVideoFonteHDDefeito);
            }

            if (gameObject.tag == "GabineteMotherBoardVideoProcessadorHDDefeito")
            {
                Destroy(Fonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito"));
                Instantiate(GabineteMotherBoardProcessadorVideoFonteHDDefeito);
            }

        }
    }
}
