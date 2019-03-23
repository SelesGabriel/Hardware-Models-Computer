using UnityEngine;
using System.Collections;

public class FPlacaGabineteFonteHD : MonoBehaviour {

    public GameObject GabineteMotherBoardFonteHD;
    public GameObject GabineteMotherBoardRAMFonteHD;
    public GameObject GabineteMotherBoardVideoFonteHD;
    public GameObject GabineteMotherBoardProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAMVideoFonteHD;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAM2VideoFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2FonteHD;

    public GameObject GabineteMotherBoardFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMFonteHDDefeito;
    public GameObject GabineteMotherBoardVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2FonteHDDefeito;

    GameObject GabineteFonteHD;
	void Update () {
        GabineteFonteHD = GameObject.FindWithTag("GabineteFonteHD");
        if (Vector3.Distance(GabineteFonteHD.transform.position, transform.position) < 5)
        {
            if (gameObject.tag == "MotherBoard")
            {
                Instantiate(GabineteMotherBoardFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoard"));
            }

            if (gameObject.tag == "MotherBoardRAM")
            {
                Instantiate(GabineteMotherBoardRAMFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM"));
            }

            if (gameObject.tag == "MotherBoardVideo")
            {
                Instantiate(GabineteMotherBoardVideoFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardVideo"));
            }

            if (gameObject.tag == "MotherBoardProcessador")
            {
                Instantiate(GabineteMotherBoardProcessadorFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
            }

            if (gameObject.tag == "MotherBoardRAMProcessador")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
            }

            if (gameObject.tag == "MotherBoardRAMVideo")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
            }

            if (gameObject.tag == "MotherBoardProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
            }

            if (gameObject.tag == "MotherBoardRAM2")
            {
                Instantiate(GabineteMotherBoardRAM2FonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
            }

            if (gameObject.tag == "MotherBoardRAMPRocessadorVideo")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
            }

            if (gameObject.tag == "MotherBoardRAM2Processador")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
            }

            if (gameObject.tag == "MotherBoardRAM2Video")
            {
                Instantiate(GabineteMotherBoardRAM2VideoFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Video"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHD);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"));
            }


            //GABINETE DEFEITO

            

            if (gameObject.tag == "MotherBoardRAMDefeito")
            {
                Instantiate(GabineteMotherBoardRAMFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMDefeito"));
            }

            if (gameObject.tag == "MotherBoardVideoDefeito")
            {
                Instantiate(GabineteMotherBoardVideoFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2Defeito")
            {
                Instantiate(GabineteMotherBoardRAM2FonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Defeito"));
            }

            if (gameObject.tag == "MotherBoardRAMPRocessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2VideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2VideoFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2VideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito);
                Destroy(GabineteFonteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito"));
            }

        }
    }
}
