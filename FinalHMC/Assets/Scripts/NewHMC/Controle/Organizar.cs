using UnityEngine;
using System.Collections;

public class Organizar : MonoBehaviour {
    public GameObject iFonte;
    public GameObject iFonteDefeito;
    public GameObject iHDDefeito;

    public GameObject GabineteFonte;
    public GameObject GabineteMotherBoardFonte;
    public GameObject GabineteMotherBoardProcessadorFonte;
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

    public GameObject GabineteFonteDefeito;
    public GameObject GabineteMotherBoardFonteDefeitoDefeito;
    public GameObject GabineteMotherBoardProcessadorFonteDefeito;
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

    public GameObject GabineteCompleto1RAMHD;
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
    public GameObject GabineteHD;

    public GameObject GabineteCompleto1RAMHDDefeito;
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
    public GameObject GabineteMotherBoardProcessadorFonteHD;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2FonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAM2VideoFonteHD;
    public GameObject GabineteMotherBoardRAMFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHD;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHD;
    public GameObject GabineteMotherBoardRAMVideoFonteHD;
    public GameObject GabineteMotherBoardVideoFonteHD;

    public GameObject GabineteFonteHDDefeito;
    public GameObject GabineteMotherBoardFonteHDDefeito;
    public GameObject GabineteMotherBoardProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2FonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAM2VideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardRAMVideoFonteHDDefeito;
    public GameObject GabineteMotherBoardVideoFonteHDDefeito;

    public GameObject iMotherBoard;
    GameObject dMotherBoard;
    
    public GameObject iProcessador;
    GameObject dProcessador;

    public GameObject iVideoBoard;
    GameObject dVideoBoard;

    public GameObject iHD;
    GameObject dHD;

    public GameObject iRAM;
    GameObject dRAM;

    public GameObject iGabinete;
    GameObject dGabinete;

    public GameObject iRAMDefeito;
    GameObject dRAMDefeito;


    
    //JUNÇÃO MOTHERBOARD

    public GameObject iMotherBoardProcessador;
    GameObject dMotherBoardProcessador;

    public GameObject iMotherBoardRAM;
    GameObject dMotherBoardRAM;

    public GameObject iMotherBoardVideo;
    GameObject dMotherBoardVideo;

    //JUNÇÃO MOTHERBOARD 2

    public GameObject iMotherBoardProcessadorVideo;
    GameObject dMotherBoardProcessadorVideo;

    public GameObject iMotherBoardRAMVideo;
    GameObject dMotherBoardRAMVideo;

    public GameObject iMotherBoardRAMProcessador;
    GameObject dMotherBoardRAMProcessador;

    public GameObject iMotherBoardRAM2;
    GameObject dMotherBoardRAM2;

    //JUNÇÃO MOTHERBOARD 3

    public GameObject iMotherBoardRAMProcessadorVideo;
    GameObject dMotherBoardRAMProcessadorVideo;

    public GameObject iMotherBoardRAM2Processador;
    GameObject dMotherBoardRAM2Processador;

    public GameObject iMotherBoardRAM2Video;
    GameObject dMotherBoardRAM2Video;

    //JUNÇÃO MOTHERBOARD 4

    public GameObject iMotherBoardRAM2ProcessadorVideo;
    GameObject dMotherBoardRAM2ProcessadorVideo;

    //JUNÇÃO GABINETE

    public GameObject iGabineteMotherBoard;
    GameObject dGabineteMotherBoard;

    //JUNÇÃO GABINETE 2

    public GameObject iGabineteMotherBoardRAM;
    GameObject dGabineteMotherBoardRAM;

    public GameObject iGabineteMotherBoardProcessador;
    GameObject dGabineteMotherBoardProcessador;

    public GameObject iGabineteMotherBoardVideo;
    GameObject dGabineteMotherBoardVideo;

    //JUNÇÃO GABINETE 3

    public GameObject iGabineteMotherBoardRAM2;
    GameObject dGabineteMotherBoardRAM2;

    public GameObject iGabineteMotherBoardRAMProcessador;
    GameObject dGabineteMotherBoardRAMProcessador;

    public GameObject iGabineteMotherBoardRAMVideo;
    GameObject dGabineteMotherBoardRAMVideo;

    public GameObject iGabineteMotherBoardProcessadorVideo;
    GameObject dGabineteMotherBoardProcessadorVideo;

    //JUNÇÃO GABINETE 4

    public GameObject iGabineteCompletoRAM1;
    GameObject dGabineteCompletoRAM1;

    public GameObject iGabineteCompleto;
    GameObject dGabineteCompleto;


    // DEFEITO

    //MOTHERBOARD
    public GameObject iMotherBoardRAMDefeito;
    GameObject dMotherBoardRAMDefeito;

    public GameObject iMotherBoardRAM2Defeito;
    GameObject dMotherBoardRAM2Defeito;

    public GameObject iMotherBoardRAMProcessadorDefeito;
    GameObject dMotherBoardRAMProcessadorDefeito;

    public GameObject iMotherBoardRAMVideoDefeito;
    GameObject dMotherBoardRAMVideoDefeito;
    public GameObject iGabineteMotherBoardRAM2Video;
    GameObject dGabineteMotherBoardRAM2Video;
    //2

    public GameObject iMotherBoardRAM2ProcessadorDefeito;
    GameObject dMotherBoardRAM2ProcessadorDefeito;

    public GameObject iMotherBoardRAM2VideoDefeito;
    GameObject dMotherBoardRAM2VideoDefeito;

    public GameObject iMotherBoardRAMProcessadorVideoDefeito;
    GameObject dMotherBoardRAMProcessadorVideoDefeito;

    //3

    public GameObject iMotherBoardRAM2ProcessadorVideoDefeito;
    GameObject dMotherBoardRAM2ProcessadorVideoDefeito;
    
    //GABINETE

    public GameObject iGabineteMotherBoardRAMDefeito;
    GameObject dGabineteMotherBoardRAMDefeito;

    public GameObject iGabineteMotherBoardRAMProcessadorDefeito;
    GameObject dGabineteMotherBoardRAMProcessadorDefeito;

    public GameObject iGabineteMotherBoardRAM2Defeito;
    GameObject dGabineteMotherBoardRAM2Defeito;

    public GameObject iGabineteMotherBoardRAMVideoDefeito;
    GameObject dGabineteMotherBoardRAMVideoDefeito;

    //2

    public GameObject iGabineteMotherBoardRAM2ProcessadorDefeito;
    GameObject dGabineteMotherBoardRAM2ProcessadorDefeito;

    public GameObject iGabineteMotherBoardRAM2VideoDefeito;
    GameObject dGabineteMotherBoardRAm2VideoDefeito;

    public GameObject iGabineteMotherBoardRAMProcessadorVideoDefeito;
    public GameObject dGabineteMotherBoardRAMProcessadorVideoDefeito;

	public GameObject iGabineteMotherBoardRAM2Processador;

    //3

    public GameObject iGabineteMotherBoardRAM2ProcessadorVideoDefeito;
    public GameObject dGabineteMotherBoardRAM2ProcessadorVideoDefeito;

    public GameObject iGabineteMotherBoardVideoDefeito;





    //GABINETE COM HD

    public GameObject iGabineteCompleto1RAMHD;
    GameObject dGabineteCompleto1RAMHD;

    public GameObject iGabineteCompletoHD;
    GameObject dGabineteCompletoHD;

    public GameObject iGabineteHD;
    GameObject dGabineteHD;

    public GameObject iGabineteMotherBoardHD;
    GameObject dGabineteMotherBoardHD;

    public GameObject iGabineteMotherBoardProcessadorHD;
    GameObject dGabineteMotherBoardProcessadorHD;

    public GameObject iGabineteMotherBoardRAM2HD;
    GameObject dGabineteMotherBoardRAM2HD;

    public GameObject iGabineteMotherBoardRAM2ProcessadorHD;
    GameObject dGabineteMotherBoardRAM2ProcessadorHD;

    public GameObject iGabineteMotherBoardRAM2VideoHD;
    GameObject dGabineteMotherBoardRAM2VideoHD;

    public GameObject iGabineteMotherBoardRAMHD;
    GameObject dGabineteMotherBoardRAMHD;

    public GameObject iGabineteMotherBoardRAMProcessadorHD;
    GameObject dGabineteMotherBoardRAMProcessadorHD;

    public GameObject iGabineteMotherBoardRAMVideoHD;
    GameObject dGabineteMotherBoardRAMVideoHD;

    public GameObject iGabineteMotherBoardVideoHD;
    GameObject dGabineteMotherBoardVideoHD;

    public GameObject iGabineteMotherBoardVideoProcessadorHD;
    GameObject dGabineteMotherBoardVideoProcessadorHD;


    //GABINETE HD COM DEFEITO

    public GameObject iGabineteCompleto1RAMHDDefeito;
    GameObject dGabineteCompleto1RAMHDDefeito;

    public GameObject iGabineteCompletoHDDefeito;
    GameObject dGabineteCompletoHDDefeito;

    public GameObject iGabineteHDDefeito;
    GameObject dGabineteHDDefeito;

    public GameObject iGabineteMotherBoardHDDefeito;
    GameObject dGabineteMotherBoardHDDefeito;

    public GameObject iGabineteMotherBoardProcessadorHDDefeito;
    GameObject dGabineteMotherBoardProcessadorHDDefeito;

    public GameObject iGabineteMotherBoardRAM2HDDefeito;
    GameObject dGabineteMotherBoardRAM2HDDefeito;

    public GameObject iGabineteMotherBoardRAM2ProcessadorHDDefeito;
    GameObject dGabineteMotherBoardRAM2ProcessadorHDDefeito;

    public GameObject iGabineteMotherBoardRAM2VideoHDDefeito;
    GameObject dGabineteMotherBoardRAM2VideoHDDefeito;

    public GameObject iGabineteMotherBoardRAMHDDefeito;
    GameObject dGabineteMotherBoardRAMHDDefeito;

    public GameObject iGabineteMotherBoardRAMProcessadorHDDefeito;
    GameObject dGabineteMotherBoardRAMProcessadorHDDefeito;

    public GameObject iGabineteMotherBoardRAMVideoHDDefeito;
    GameObject dGabineteMotherBoardRAMVideoHDDefeito;

    public GameObject iGabineteMotherBoardVideoHDDefeito;
    GameObject dGabineteMotherBoardVideoHDDefeito;

    public GameObject iGabineteMotherBoardVideoProcessadorHDDefeito;
    GameObject dGabineteMotherBoardVideoProcessadorHDDefeito;

    void Start(){
		dGabineteMotherBoardRAM2ProcessadorVideoDefeito = GameObject.FindWithTag ("GabineteCompletoDefeito");
        //dGabineteMotherBoardRAMProcessadorVideoDefeito = GameObject.FindWithTag ("GabineteCompletoRAM1Defeito");
        //Instantiate(iGabineteMotherBoardRAMProcessadorVideoDefeito);
	}
    
	public void Update () {

        try
        {
            dMotherBoard = GameObject.FindWithTag("MotherBoard");
            dProcessador = GameObject.FindWithTag("Processador");
            dRAM = GameObject.FindWithTag("RAM");
            dGabinete = GameObject.FindWithTag("Gabinete");
            dHD = GameObject.FindWithTag("HD");
            dVideoBoard = GameObject.FindWithTag("VideoBoard");
            dRAMDefeito = GameObject.FindWithTag("RAMDefeito");

            //JUNÇÃO MOTHERBOARD 2
            dMotherBoardProcessador = GameObject.FindWithTag("MotherBoardProcessador");
            dMotherBoardRAM = GameObject.FindWithTag("MotherBoardRAM");
            dMotherBoardVideo = GameObject.FindWithTag("MotherBoardVideo");


            //JUNÇÃO MOTHERBOARD 3

            dMotherBoardProcessadorVideo = GameObject.FindWithTag("MotherBoardProcessadorVideo");
            dMotherBoardRAMProcessador = GameObject.FindWithTag("MotherBoardRAMProcessador");
            dMotherBoardRAMVideo = GameObject.FindWithTag("MotherBoardRAMVideo");
            dMotherBoardRAM2 = GameObject.FindWithTag("MotherBoardRAM2");

            //JUNÇÃO MOTHERBOARD 4 
            dMotherBoardRAM2Processador = GameObject.FindWithTag("MotherBoardRAM2Processador");
            dMotherBoardRAM2Video = GameObject.FindWithTag("MotherBoardRAM2Video");
            dMotherBoardRAM2ProcessadorVideo = GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo");
            dMotherBoardRAMProcessadorVideo = GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo");

            //JUNÇÃO GABINETE

            dGabineteMotherBoard = GameObject.FindWithTag("GabineteMotherBoard");

            //JUNÇÃO GABINETE 2

            dGabineteMotherBoardRAM = GameObject.FindWithTag("GabineteMotherBoardRAM");
            dGabineteMotherBoardProcessador = GameObject.FindWithTag("GabineteMotherBoardProcessador");
            dGabineteMotherBoardVideo = GameObject.FindWithTag("GabineteMotherBoardVideo");

            //JUNÇÃO GABINETE 3

            dGabineteMotherBoardRAM2 = GameObject.FindWithTag("GabineteMotherBoardRAM2");
            dGabineteMotherBoardRAMProcessador = GameObject.FindWithTag("GabineteMotherBoardRAMProcessador");
            dGabineteMotherBoardRAMVideo = GameObject.FindWithTag("GabineteMotherBoardRAMVideo");
            dGabineteMotherBoardProcessadorVideo = GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo");

            //JUNÇÃO GABINETE 4

            dGabineteCompleto = GameObject.FindWithTag("GabineteCompleto");
            dGabineteCompletoRAM1 = GameObject.FindWithTag("GabineteCompletoRAM1");

            //MOTHERBOARD DEFEITO

            dMotherBoardRAMDefeito = GameObject.FindWithTag("MotherBoardRAMDefeito");
            dMotherBoardRAM2Defeito = GameObject.FindWithTag("MotherBoardRAM2Defeito");
            dMotherBoardRAMVideoDefeito = GameObject.FindWithTag("MotherBoardRAMVideoDefeito");
            dMotherBoardRAMProcessadorDefeito = GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito");
            dMotherBoardRAM2ProcessadorDefeito = GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito");
            dMotherBoardRAM2VideoDefeito = GameObject.FindWithTag("MotherBoardRAM2VideoDefeito");
            dMotherBoardRAMProcessadorVideoDefeito = GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito");
            dMotherBoardRAM2ProcessadorVideoDefeito = GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito");

            //GABINETE DEFEITO

            dGabineteMotherBoardRAMDefeito = GameObject.FindWithTag("GabineteMotherBoardRAMDefeito");
            dGabineteMotherBoardRAMProcessadorDefeito = GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito");
            dGabineteMotherBoardRAM2Defeito = GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito");
            dGabineteMotherBoardRAMVideoDefeito = GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito");
            dGabineteMotherBoardRAM2ProcessadorDefeito = GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorDefeito");
            dGabineteMotherBoardRAm2VideoDefeito = GameObject.FindWithTag("GabineteMotherBoardRAm2VideoDefeito");
            dGabineteMotherBoardRAMProcessadorVideoDefeito = GameObject.FindWithTag("GabineteCompletoRAM1Defeito");
            dGabineteMotherBoardRAM2ProcessadorVideoDefeito = GameObject.FindWithTag("GabineteCompletoDefeito");

            //GABINETE COM HD

            dGabineteCompleto1RAMHD = GameObject.FindWithTag("GabineteCompleto1RAMHD");
            dGabineteCompletoHD = GameObject.FindWithTag("GabineteCompletoHD");
            dGabineteMotherBoardHD = GameObject.FindWithTag("GabineteMotherBoardHD");
            dGabineteMotherBoardProcessadorHD = GameObject.FindWithTag("GabineteMotherBoardProcessadorHD");
            dGabineteMotherBoardRAM2HD = GameObject.FindWithTag("GabineteMotherBoardRAM2HD");
            dGabineteMotherBoardRAM2ProcessadorHD = GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD");
            dGabineteMotherBoardRAM2VideoHD = GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD");
            dGabineteMotherBoardRAMHD = GameObject.FindWithTag("GabineteMotherBoardRAMHD");
            dGabineteMotherBoardRAMProcessadorHD = GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD");
            dGabineteMotherBoardRAMVideoHD = GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD");
            dGabineteMotherBoardVideoHD = GameObject.FindWithTag("GabineteMotherBoardVideoHD");
            dGabineteMotherBoardVideoProcessadorHD = GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD");



            //GABINETE HD COM DEFEITO
            dGabineteCompleto1RAMHDDefeito = GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito");
            dGabineteCompletoHDDefeito = GameObject.FindWithTag("GabineteCompletoHDDefeito");
            dGabineteMotherBoardHDDefeito = GameObject.FindWithTag("GabineteMotherBoardHDDefeito");
            dGabineteMotherBoardProcessadorHDDefeito = GameObject.FindWithTag("GabineteMotherBoardProcessadorHDDefeito");
            dGabineteMotherBoardRAM2HDDefeito = GameObject.FindWithTag("GabineteMotherBoardRAM2HDDefeito");
            dGabineteMotherBoardRAM2ProcessadorHDDefeito = GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHDDefeito");
            dGabineteMotherBoardRAM2VideoHDDefeito = GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHDDefeito");
            dGabineteMotherBoardRAMHDDefeito = GameObject.FindWithTag("GabineteMotherBoardRAMHDDefeito");
            dGabineteMotherBoardRAMProcessadorHDDefeito = GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHDDefeito");
            dGabineteMotherBoardRAMVideoHDDefeito = GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito");
            dGabineteMotherBoardVideoHDDefeito = GameObject.FindWithTag("GabineteMotherBoardVideoHDDefeito");
            dGabineteMotherBoardVideoProcessadorHDDefeito = GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito");

        }
        catch (System.Exception)
        {

            print("erro");
        }
        
    }

    public void FOrganization()
    {

        //COMPONENTES

        if (GameObject.FindWithTag("Fonte"))
        {
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("Fonte"));
        }

        if (GameObject.FindWithTag("MotherBoard"))
        {
            Instantiate(iMotherBoard);
            Destroy(dMotherBoard);
        }

        if (GameObject.FindWithTag("Processador"))
        {
            Instantiate(iProcessador);
            Destroy(dProcessador);
        }

        if (GameObject.FindWithTag("HD"))
        {
            Instantiate(iHD);
            Destroy(dHD);
        }

        if (GameObject.FindWithTag("RAM"))
        {
            Instantiate(iRAM);
            Destroy(dRAM);
        }

        if (GameObject.FindWithTag("VideoBoard"))
        {
            Instantiate(iVideoBoard);
            Destroy(dVideoBoard);
        }

        if (GameObject.FindWithTag("Gabinete"))
        {
            Instantiate(iGabinete);
            Destroy(dGabinete);
        }

        //JUNCAO
        if (GameObject.FindWithTag("MotherBoardProcessador"))
        {
            Instantiate(iMotherBoardProcessador);
            Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
        }

        if (GameObject.FindWithTag("MotherBoardProcessadorVideo"))
        {
            Instantiate(iMotherBoardProcessadorVideo);
            Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM"))
        {
            Instantiate(iMotherBoardRAM);
            Destroy(GameObject.FindWithTag("MotherBoardRAM"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2"))
        {
            Instantiate(iMotherBoardRAM2);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2Processador"))
        {
            Instantiate(iMotherBoardRAM2Processador);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"))
        {
            Instantiate(iMotherBoardRAM2ProcessadorVideo);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2Video"))
        {
            Instantiate(iMotherBoardRAM2Video);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2Video"));
        }

        if (GameObject.FindWithTag("MotherBoardRAMProcessador"))
        {
            Instantiate(iMotherBoardRAMProcessador);
            Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
        }

        if (GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"))
        {
            Instantiate(iMotherBoardRAMProcessadorVideo);
            Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardRAMVideo"))
        {
            Instantiate(iMotherBoardRAMVideo);
            Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardVideo"))
        {
            Instantiate(iMotherBoardVideo);
            Destroy(GameObject.FindWithTag("MotherBoardVideo"));
        }



        //Gabinete
        if (GameObject.FindWithTag("GabineteCompleto"))
        {
            Instantiate(iGabineteCompleto);
            Destroy(GameObject.FindWithTag("GabineteCompleto"));
        }

        if (GameObject.FindWithTag("GabineteCompletoRAM1"))
        {
            Instantiate(iGabineteCompletoRAM1);
            Destroy(GameObject.FindWithTag("GabineteCompletoRAM1"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoard"))
        {
            Instantiate(iGabineteMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessador"))
        {
            Instantiate(iGabineteMotherBoardProcessador);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"))
        {
            Instantiate(iGabineteMotherBoardProcessadorVideo);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM"))
        {
            Instantiate(iGabineteMotherBoardRAM);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2"))
        {
            Instantiate(iGabineteMotherBoardRAM2);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"))
        {
            Instantiate(iGabineteMotherBoardRAM2Processador);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2Video"))
        {
            Instantiate(iGabineteMotherBoardRAM2Video);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Video"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"))
        {
            Instantiate(iGabineteMotherBoardRAMProcessador);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideo"))
        {
            Instantiate(iGabineteMotherBoardRAMVideo);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideo"))
        {
            Instantiate(iGabineteMotherBoardVideo);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
        }

        //GABINETE COM FONTE

        if (GameObject.FindWithTag("GabineteFonte"))
        {
            Instantiate(GabineteFonte);
            Destroy(GameObject.FindWithTag("GabineteFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardFonte"))
        {
            Instantiate(GabineteMotherBoardFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte"))
        {
            Instantiate(GabineteMotherBoardProcessadorFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte"))
        {
            Instantiate(GabineteMotherBoardProcessadorVideoFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte"))
        {
            Instantiate(GabineteMotherBoardRAM2Fonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte"))
        {
            Instantiate(GabineteMotherBoardRAM2ProcessadorFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte"))
        {
            Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte"))
        {
            Instantiate(GabineteMotherBoardRAM2VideoFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMFonte"))
        {
            Instantiate(GabineteMotherBoardRAMFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte"))
        {
            Instantiate(GabineteMotherBoardRAMProcessadorFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte"))
        {
            Instantiate(GabineteMotherBoardRAMProcessadorVideoFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte"))
        {
            Instantiate(GabineteMotherBoardRAMVideoFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoFonte"))
        {
            Instantiate(GabineteMotherBoardVideoFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonte"));
        }


        //GABINETE HD
        if (GameObject.FindWithTag("GabineteCompleto1RAMHD"))
        {
            Instantiate(GabineteCompleto1RAMHD);
            Destroy(GameObject.FindWithTag("GabineteCompleto1RAMHD"));
        }

        if (GameObject.FindWithTag("GabineteCompletoHD"))
        {
            Instantiate(GabineteCompletoHD);
            Destroy(GameObject.FindWithTag("GabineteCompletoHD"));
        }

        if (GameObject.FindWithTag("GabineteHD"))
        {
            Instantiate(GabineteHD);
            Destroy(GameObject.FindWithTag("GabineteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardHD"))
        {
            Instantiate(GabineteMotherBoardHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorHD"))
        {
            Instantiate(GabineteMotherBoardProcessadorHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2HD"))
        {
            Instantiate(GabineteMotherBoardRAM2HD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2HD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD"))
        {
            Instantiate(GabineteMotherBoardRAM2ProcessadorHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD"))
        {
            Instantiate(GabineteMotherBoardRAM2VideoHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMHD"))
        {
            Instantiate(GabineteMotherBoardRAMHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD"))
        {
            Instantiate(GabineteMotherBoardRAMProcessadorHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD"))
        {
            Instantiate(GabineteMotherBoardRAMVideoHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoHD"))
        {
            Instantiate(GabineteMotherBoardVideoHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD"))
        {
            Instantiate(GabineteMotherBoardVideoProcessadorHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD"));
        }


        //GABINETE FONTE HD

        if (GameObject.FindWithTag("GabineteFonteHD"))
        {
            Instantiate(GabineteFonteHD);
            Destroy(GameObject.FindWithTag("GabineteFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardFonteHD"))
        {
            Instantiate(GabineteMotherBoardFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD"))
        {
            Instantiate(GabineteMotherBoardProcessadorFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD"))
        {
            Instantiate(GabineteMotherBoardProcessadorVideoFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD"))
        {
            Instantiate(GabineteMotherBoardRAM2FonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD"))
        {
            Instantiate(GabineteMotherBoardRAM2ProcessadorFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD"))
        {
            Instantiate(GabineteMotherBoardRAM2ProcessadorVideoFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD"))
        {
            Instantiate(GabineteMotherBoardRAM2VideoFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD"))
        {
            Instantiate(GabineteMotherBoardRAMFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD"))
        {
            Instantiate(GabineteMotherBoardRAMProcessadorFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD"))
        {
            Instantiate(GabineteMotherBoardRAMProcessadorVideoFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD"))
        {
            Instantiate(GabineteMotherBoardRAMVideoFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD"))
        {
            Instantiate(GabineteMotherBoardVideoFonteHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD"));
        }
    }


    public void Desmontar()
    {
        //JUNCAO 
        if (GameObject.FindWithTag("MotherBoardProcessador"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iProcessador);
            Destroy(GameObject.FindWithTag("MotherBoardProcessador"));
        }

        if (GameObject.FindWithTag("MotherBoardProcessadorVideo"))
        {
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardProcessadorVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM"))
        {
            Instantiate(iRAM);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAM"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2Processador"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2Processador"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardRAM2Video"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAM2Video"));
        }

        if (GameObject.FindWithTag("MotherBoardRAMProcessador"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAMProcessador"));
        }

        if (GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardRAMVideo"))
        {
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardRAMVideo"));
        }

        if (GameObject.FindWithTag("MotherBoardVideo"))
        {
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("MotherBoardVideo"));
        }



        //GABINETE

        if (GameObject.FindWithTag("GabineteCompleto"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteCompleto"));
        }

        if (GameObject.FindWithTag("GabineteCompletoRAM1"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteCompletoRAM1"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoard"))
        {
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoard"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessador"))
        {
            Instantiate(iProcessador);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessador"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"))
        {
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM"))
        {
            Instantiate(iRAM);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Processador"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2Video"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Video"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideo"))
        {
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideo"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideo"))
        {
            Instantiate(iVideoBoard);
            Instantiate(iGabinete);
            Instantiate(iMotherBoard);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideo"));
        }


        //GABINETE COM FONTE

        if (GameObject.FindWithTag("GabineteFonte"))
        {
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardFonte"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte"))
        {
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte"))
        {
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte"));
        }


        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMFonte"))
        {
            Instantiate(iRAM);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonte"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte"));
        }


        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte"));
        }


        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte"))
        {
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte"));
        }


        if (GameObject.FindWithTag("GabineteMotherBoardVideoFonte"))
        {
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iFonte);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonte"));
        }

        //GABINETE HD
        if (GameObject.FindWithTag("GabineteHD"))
        {
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardHD"));
        }

        if (GameObject.FindWithTag("GabineteCompleto1RAMHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteCompleto1RAMHD"));
        }

        if (GameObject.FindWithTag("GabineteCompletoHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteCompletoHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2HD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2HD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iGabinete);
            Instantiate(iHD);
            Instantiate(iVideoBoard);
            Instantiate(iProcessador);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD"));
        }



        //GABINETE FONTE HD
        if (GameObject.FindWithTag("GabineteFonteHD"))
        {
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardFonteHD"))
        {
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD"))
        {
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD"))
        {
            Instantiate(iVideoBoard);
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iProcessador);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD"))
        {
            Instantiate(iRAM);
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD"));
        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD"))
        {
            Instantiate(iVideoBoard);
            Instantiate(iMotherBoard);
            Instantiate(iHD);
            Instantiate(iFonte);
            Instantiate(iGabinete);
            Destroy(GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD"));
        }


    }
}
