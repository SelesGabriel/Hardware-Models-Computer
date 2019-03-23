using UnityEngine;
using System.Collections;

public class FPlacaGabineteFonte : MonoBehaviour {

    public GameObject GabineteMotherBoardFonte;
    public GameObject GabineteMotherBoardRAMFonte;
    public GameObject GabineteMotherBoardVideoFonte;
    public GameObject GabineteMotherBoardProcessadorFonte;
    public GameObject GabineteMotherBoardRAMProcessadorFonte;
    public GameObject GabineteMotherBoardRAMVideoFonte;
    public GameObject GabineteMotherBoardProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonte;
    public GameObject GabineteMotherBoardRAM2VideoFonte;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonte;
    public GameObject GabineteMotherBoardRAM2Fonte;

    public GameObject GabineteMotherBoardFonteDefeito;
    public GameObject GabineteMotherBoardRAMFonteDefeito;
    public GameObject GabineteMotherBoardVideoFonteDefeito;
    public GameObject GabineteMotherBoardProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFoDefeitonte;
    public GameObject GabineteMotherBoardRAMVideoFonteDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito;
    public GameObject GabineteMotherBoardRAM2FonteDefeito;


    GameObject GabineteFonte;
	void Update () {
        GabineteFonte = GameObject.FindWithTag("GabineteFonte");
        if (Vector3.Distance(GabineteFonte.transform.position, transform.position) < 5)
        {
            if (gameObject.tag == "MotherBoard")
            {
                Instantiate(GabineteMotherBoardFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoard"));
            }

            if (gameObject.tag == "MotherBoardRAM")
            {
                Instantiate(GabineteMotherBoardRAMFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAM"));
            }

            if (gameObject.tag == "MotherBoardVideo")
            {
                Instantiate(GabineteMotherBoardVideoFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardVideo"));
            }

            if (gameObject.tag == "MotherBoardProcessador")
            {
                Instantiate(GabineteMotherBoardProcessadorFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
            }

            if (gameObject.tag == "MotherBoardRAMProcessador")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
            }

            if (gameObject.tag == "MotherBoardRAMVideo")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
            }

            if (gameObject.tag == "MotherBoardProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
            }

            if (gameObject.tag == "MotherBoardRAM2")
            {
                Instantiate(GabineteMotherBoardRAM2Fonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
            }

            if (gameObject.tag == "MotherBoardRAMPRocessadorVideo")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
            }

            if (gameObject.tag == "MotherBoardRAM2Processador")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
            }

            if (gameObject.tag == "MotherBoardRAM2Video")
            {
                Instantiate(GabineteMotherBoardRAM2VideoFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Video"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"));
            }


            //GABINETE DEFEITO

            if (gameObject.tag == "MotherBoardRAMProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoFonteDefeito);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2Defeito")
            {
                Instantiate(GabineteMotherBoardRAM2FonteDefeito);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorFonteDefeito);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2VideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2VideoFonteDefeito);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2VideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMDefeito")
            {
                Instantiate(GabineteMotherBoardRAMFonteDefeito);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAMDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorFoDefeitonte);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMVideoFonteDefeito);
                Destroy(GabineteFonte);
                Destroy(GameObject.FindWithTag("MotherBoardRAMVideoDefeito"));
            }

        }
    }
}
