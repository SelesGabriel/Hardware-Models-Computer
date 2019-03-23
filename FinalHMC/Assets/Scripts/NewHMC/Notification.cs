using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;


public class Notification : MonoBehaviour {

    //public GameObject toolTip;
    public GameObject TextRAM;
    public GameObject TextProcessador;
    public GameObject TextVideoBoard;
    public GameObject TextMotherBoard;
    public GameObject TextGabinete;
    public GameObject TextHD;
    public GameObject fechar;

    //DESMONTAR PEÇAS
    public GameObject GabineteCompletoRAM1;
    public GameObject RAMDefeito;
    public GameObject Processador;
    public GameObject VideoBoard;
    public GameObject MotherBoard;
    public GameObject Gabinete;


    void Start () 
    {
        GabineteCompletoRAM1 = GameObject.FindWithTag("GabineteCompletoRAM1Defeito");
        /*TextRAM = GameObject.FindWithTag("NotificationRAM");
        TextProcessador = GameObject.FindWithTag("NotificationProcessador");
        TextVideoBoard = GameObject.FindWithTag("NotificationVideoBoard");
        TextMotherBoard = GameObject.FindWithTag("NotificationMotherBoard");
        TextGabinete = GameObject.FindWithTag("NotificationGabinete");
        TextHD = GameObject.FindWithTag("NotificationHD");*/
    }

	void Update () {
        /*if (Input.GetKey("j"))
        {
            toolTip.SetActive(true);
        }
        else
            toolTip.SetActive(false);*/
	}
    
    //MOSTRAR
    public void MostrarRAM()
    {
        //TextHD.SetActive(true);
        TextRAM.SetActive(true);
        //TextVideoBoard.SetActive(true);
        //TextMotherBoard.SetActive(true);
        //TextGabinete.SetActive(true);
        //TextProcessador.SetActive(true);
    }

    public void MostrarProcessador()
    {
        //TextHD.SetActive(true);
        //TextRAM.SetActive(true);
        //TextVideoBoard.SetActive(true);
        //TextMotherBoard.SetActive(true);
        //TextGabinete.SetActive(true);
        TextProcessador.SetActive(true);
    }

    public void MostrarHD()
    {
        TextHD.SetActive(true);
        //TextRAM.SetActive(true);
        //TextVideoBoard.SetActive(true);
        //TextMotherBoard.SetActive(true);
        //TextGabinete.SetActive(true);
        //TextProcessador.SetActive(true);
    }

    public void MostrarGabinete()
    {
        //TextHD.SetActive(true);
        //TextRAM.SetActive(true);
        //TextVideoBoard.SetActive(true);
        //TextMotherBoard.SetActive(true);
        TextGabinete.SetActive(true);
        //TextProcessador.SetActive(true);
    }

    public void MostrarVideoBoard()
    {
        //TextHD.SetActive(true);
        //TextRAM.SetActive(true);
        TextVideoBoard.SetActive(true);
        //TextMotherBoard.SetActive(true);
        //TextGabinete.SetActive(true);
        //TextProcessador.SetActive(true);
    }

    public void MostrarMotherBoard()
    {
        //TextHD.SetActive(true);
        //TextRAM.SetActive(true);
        //TextVideoBoard.SetActive(true);
        TextMotherBoard.SetActive(true);
        //TextGabinete.SetActive(true);
        //TextProcessador.SetActive(true);
    }


    //ESCONDER
    public void EsconderMenosRAM()
    {
        TextHD.SetActive(false);
        //TextRAM.SetActive(false);
        TextVideoBoard.SetActive(false);
        TextMotherBoard.SetActive(false);
        TextGabinete.SetActive(false);
        TextProcessador.SetActive(false);
    }

    public void EsconderMenosMotherBoard()
    {
        TextHD.SetActive(false);
        TextRAM.SetActive(false);
        TextVideoBoard.SetActive(false);
        //TextMotherBoard.SetActive(false);
        TextGabinete.SetActive(false);
        TextProcessador.SetActive(false);
    }

    public void EsconderMenosProcessador()
    {
        TextHD.SetActive(false);
        TextRAM.SetActive(false);
        TextVideoBoard.SetActive(false);
        TextMotherBoard.SetActive(false);
        TextGabinete.SetActive(false);
        //TextProcessador.SetActive(false);
    }

    public void EsconderMenosHD()
    {
        //TextHD.SetActive(false);
        TextRAM.SetActive(false);
        TextVideoBoard.SetActive(false);
        TextMotherBoard.SetActive(false);
        TextGabinete.SetActive(false);
        TextProcessador.SetActive(false);
    }

    public void EsconderMenosGabinete()
    {
        TextHD.SetActive(false);
        TextRAM.SetActive(false);
        TextVideoBoard.SetActive(false);
        TextMotherBoard.SetActive(false);
        //TextGabinete.SetActive(false);
        TextProcessador.SetActive(false);
    }

    public void EsconderMenosVideoBoard()
    {
        TextHD.SetActive(false);
        TextRAM.SetActive(false);
        //TextVideoBoard.SetActive(false);
        TextMotherBoard.SetActive(false);
        TextGabinete.SetActive(false);
        TextProcessador.SetActive(false);
    }

    //FECHAR
    public void Fechar()
    {
        fechar.SetActive(false);
    }


    //BOTAO DESMONTAR 
    public void DesmontarGabineteRAM1()
    {
        if (GabineteCompletoRAM1)
        {
            print("ae");
            Destroy(GabineteCompletoRAM1);
            Instantiate(RAMDefeito);
            Instantiate(Processador);
            Instantiate(VideoBoard);
            Instantiate(MotherBoard);
            Instantiate(Gabinete);
        }

        else
            print("Boa MLK");

    }
}
