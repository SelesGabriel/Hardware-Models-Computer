using UnityEngine;
using System.Collections;

public class FPlacaGabineteHD : MonoBehaviour {

    public GameObject GabineteMotherBoardHD;
    public GameObject GabineteMotherBoardRAMHD;
    public GameObject GabineteMotherBoardVideoHD;
    public GameObject GabineteMotherBoardProcessadorHD;
    public GameObject GabineteMotherBoardRAMProcessadorHD;
    public GameObject GabineteMotherBoardRAMVideoHD;
    public GameObject GabineteMotherBoardProcessadorVideoHD;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorHD;
    public GameObject GabineteMotherBoardRAM2VideoHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoHD;
    public GameObject GabineteMotherBoardRAM2HD;

    public GameObject GabineteMotherBoardHDDefeito;
    public GameObject GabineteMotherBoardRAMHDDefeito;
    public GameObject GabineteMotherBoardVideoHDDefeito;
    public GameObject GabineteMotherBoardProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoHDDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoHDDefeito;
    public GameObject GabineteMotherBoardRAMPRocessadorVideoHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoHDDefeito;
    public GameObject GabineteMotherBoardRAM2HDDefeito;

    GameObject GabineteHD;
	void Update () {
        GabineteHD = GameObject.FindWithTag("GabineteHD");
        if (Vector3.Distance(GabineteHD.transform.position, transform.position) < 5)
        {
            if (gameObject.tag == "MotherBoard")
            {
                Instantiate(GabineteMotherBoardHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoard"));
            }

            if (gameObject.tag == "MotherBoardRAM")
            {
                Instantiate(GabineteMotherBoardRAMHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM"));
            }

            if (gameObject.tag == "MotherBoardVideo")
            {
                Instantiate(GabineteMotherBoardVideoHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardVideo"));
            }

            if (gameObject.tag == "MotherBoardProcessador")
            {
                Instantiate(GabineteMotherBoardProcessadorHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
            }

            if (gameObject.tag == "MotherBoardRAMProcessador")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
            }

            if (gameObject.tag == "MotherBoardRAMVideo")
            {
                Instantiate(GabineteMotherBoardRAMVideoHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
            }

            if (gameObject.tag == "MotherBoardProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
            }

            if (gameObject.tag == "MotherBoardRAM2")
            {
                Instantiate(GabineteMotherBoardRAM2HD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
            }

            if (gameObject.tag == "MotherBoardRAMPRocessadorVideo")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
            }

            if (gameObject.tag == "MotherBoardRAM2Processador")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
            }

            if (gameObject.tag == "MotherBoardRAM2Video")
            {
                Instantiate(GabineteMotherBoardRAM2VideoHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Video"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorVideo")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoHD);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"));
            }


            //GABINETE DEFEITO

            if (gameObject.tag == "MotherBoardDefeito")
            {
                Instantiate(GabineteMotherBoardHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMDefeito")
            {
                Instantiate(GabineteMotherBoardRAMHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMDefeito"));
            }

            if (gameObject.tag == "MotherBoardVideoDefeito")
            {
                Instantiate(GabineteMotherBoardVideoHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAMProcessadorHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAMVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMVideoHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardProcessadorVideoHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2Defeito")
            {
                Instantiate(GabineteMotherBoardRAM2HDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2Defeito"));
            }

            if (gameObject.tag == "MotherBoardRAMPRocessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAMPRocessadorVideoHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2VideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2VideoHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2VideoDefeito"));
            }

            if (gameObject.tag == "MotherBoardRAM2ProcessadorVideoDefeito")
            {
                Instantiate(GabineteMotherBoardRAM2ProcessadorVideoHDDefeito);
                Destroy(GabineteHD);
                Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito"));
            }

        }
    }
}
