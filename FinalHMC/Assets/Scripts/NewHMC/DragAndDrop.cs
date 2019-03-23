using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    GameObject txtRAM;
    GameObject txtHD;
    GameObject txtGabinete;
    GameObject txtProcessador;
    GameObject txtVideoBoard;
    GameObject txtMotherBoard;
    GameObject txtFonte;
    public GameObject RAM;
    public GameObject MotherBoard;
    public GameObject VideoBoard;
    public GameObject Processador;
    public GameObject Gabinete;
    public GameObject HD;
    public GameObject Fonte;

    void Start()
    {
        txtRAM = GameObject.FindWithTag("txtRAM");
        txtHD = GameObject.FindWithTag("txtHD");
        txtGabinete = GameObject.FindWithTag("txtGabinete");
        txtProcessador = GameObject.FindWithTag("txtProcessador");
        txtVideoBoard = GameObject.FindWithTag("txtVideoBoard");
        txtMotherBoard = GameObject.FindWithTag("txtMotherBoard");
        txtFonte = GameObject.FindWithTag("txtFonte");
    }

    void Update()
    {
        
    }

    public static GameObject itemDrag;
    Vector2 startPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemDrag = gameObject;
        startPosition = transform.position;
       
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemDrag = null;
        transform.position = startPosition;
    }

    public void InstanciarRAM()
    {
        if (Vector2.Distance(txtRAM.transform.position, transform.position) > 100)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (GameObject.FindWithTag("RAM") || GameObject.FindWithTag("RAMDefeito") || GameObject.FindWithTag("GabineteCompleto") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2") || GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") || GameObject.FindWithTag("GabineteMotherBoardRAM2Video") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteDefeito") || GameObject.FindWithTag("GabineteCompletoDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") || GameObject.FindWithTag("GabineteCompletoHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2HD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD") ||
                    GameObject.FindWithTag("GabineteCompletoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2HDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHDDefeito") ||
                    GameObject.FindWithTag("MotherBoardRAM2Defeito") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito") ||
                    GameObject.FindWithTag("MotherBoardRAM2VideoDefeito") || GameObject.FindWithTag("MotherBoardRAM2") || GameObject.FindWithTag("MotherBoardRAM2Processador") ||
                    GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo") || GameObject.FindWithTag("MotherBoardRAM2Video"))

                {
                    print("ja tem");
                }

                else
                {
                    Instantiate(RAM, transform.position, transform.rotation);
                    transform.position = startPosition;
                }
            }
        }        
    }

    public void InstanciarPlacaMae()
    {
        try
        {
            if (Vector2.Distance(txtMotherBoard.transform.position, transform.position) > 100)
            {
                if (Input.GetMouseButtonUp(0))
                {

                    //COMPONENTES / JUNCAO
                    if (GameObject.FindWithTag("MotherBoard") || GameObject.FindWithTag("MotherBoardDefeito") || GameObject.FindWithTag("MotherBoardProcessador") ||
                        GameObject.FindWithTag("MotherBoardProcessadorVideo") || GameObject.FindWithTag("MotherBoardRAM") || GameObject.FindWithTag("MotherBoardRAM2") ||
                        GameObject.FindWithTag("MotherBoardRAM2Processador") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo") || GameObject.FindWithTag("MotherBoardRAM2Video") ||
                        GameObject.FindWithTag("MotherBoardRAMProcessador") || GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo") || GameObject.FindWithTag("MotherBoardRAMVideo") ||
                        GameObject.FindWithTag("MotherBoardVideo") ||


                        //GABINETE
                        GameObject.FindWithTag("GabineteCompleto") || GameObject.FindWithTag("GabineteCompletoRAM1") || GameObject.FindWithTag("GabineteMotherBoard") ||
                        GameObject.FindWithTag("GabineteMotherBoardProcessador") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo") || GameObject.FindWithTag("GabineteMotherBoardRAM") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2") || GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") || GameObject.FindWithTag("GabineteMotherBoardRAM2Video") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMProcessador") || GameObject.FindWithTag("GabineteMotherBoardRAMVideo") || GameObject.FindWithTag("GabineteMotherBoardVideo") ||



                        //GABINETE COM FONTE
                        GameObject.FindWithTag("GabineteMotherBoardFonte") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardVideoFonte") ||



                        //GABINETE COM FONTE (DEFEITO)
                        GameObject.FindWithTag("GabineteMotherBoardFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2FonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteDefeito") ||



                        //GABINETE DEFEITO
                        GameObject.FindWithTag("GabineteCompletoDefeito") || GameObject.FindWithTag("GabineteCompletoRAM1Defeito") || GameObject.FindWithTag("GabineteMotherBoardDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") || GameObject.FindWithTag("GabineteMotherBoardRAMDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMVideo") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoDefeito") ||
                        
                       
                        //GABINETE HD
                        GameObject.FindWithTag("GabineteCompleto1RAMHD") || GameObject.FindWithTag("GabineteCompletoHD") || GameObject.FindWithTag("GabineteMotherBoardHD") ||
                        GameObject.FindWithTag("GabineteMotherBoardProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2HD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD") || GameObject.FindWithTag("GabineteMotherBoardRAMHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD") || GameObject.FindWithTag("GabineteMotherBoardVideoHD") || GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD") ||
                        

                        
                        //GABINETE HD (DEFEITO)
                        GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito") || GameObject.FindWithTag("GabineteCompletoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardHDDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2HDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHDDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHDDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito") ||
                        


                        //GABINETE FONTE HD
                        GameObject.FindWithTag("GabineteMotherBoardFonteHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD") ||
                        

                       
                        //GABINETE FONTE HD (DEFEITO)
                        GameObject.FindWithTag("GabineteMotherBoardFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHDDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHDDefeito") ||
                        GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHDDefeito") ||
                        

                        
                        //JUNÇÃO DEFEITO
                        GameObject.FindWithTag("MotherBoardRAM2Defeito") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito") ||
                        GameObject.FindWithTag("MotherBoardRAM2VideoDefeito") || GameObject.FindWithTag("MotherBoardRAMDefeito") || GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito") ||
                        GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito") || GameObject.FindWithTag("MotherBoardRAMVideoDefeito") || GameObject.FindWithTag("MotherBoardVideoDefeito"))

                    {
                        print("ERRO");
                    }

                    else
                    {
                        Instantiate(MotherBoard, transform.position, transform.rotation);
                        transform.position = startPosition;
                    }
                }
            
            }
        }
        catch (System.Exception)
        {

            print("SEI LAAA");
        }
    }

    public void InstanciarGabinete()
    {
        if (Vector2.Distance(txtGabinete.transform.position, transform.position) > 100)
        {
            if (Input.GetMouseButtonUp(0))
            {

                //GABINETE
                if (GameObject.FindWithTag("Gabinete") || GameObject.FindWithTag("GabineteCompleto") || GameObject.FindWithTag("GabineteCompletoRAM1") ||
                    GameObject.FindWithTag("GabineteMotherBoard") || GameObject.FindWithTag("GabineteMotherBoardProcessador") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM") || GameObject.FindWithTag("GabineteMotherBoardRAM2") || GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2Video") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessador") || GameObject.FindWithTag("GabineteMotherBoardRAMVideo") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideo") ||


                    //GABINETE COM FONTE
                    GameObject.FindWithTag("GabineteFonte") || GameObject.FindWithTag("GabineteMotherBoardFonte") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoFonte") ||

                    
                    //GABINETE COM FONTE (DEFEITO) 
                    GameObject.FindWithTag("GabineteFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoFonteDefeito") ||


                    //GABINETE DEFEITO
                    GameObject.FindWithTag("GabineteCompletoDefeito") || GameObject.FindWithTag("GabineteCompletoRAM1Defeito") || GameObject.FindWithTag("GabineteMotherBoardDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") || GameObject.FindWithTag("GabineteMotherBoardRAMDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMVideo") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoDefeito") ||
                    

                    //GABINETE HD
                    GameObject.FindWithTag("GabineteCompleto1RAMHD") || GameObject.FindWithTag("GabineteCompletoHD") || GameObject.FindWithTag("GabineteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2HD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD") || GameObject.FindWithTag("GabineteMotherBoardRAMHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD") || GameObject.FindWithTag("GabineteMotherBoardVideoHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD") ||


                    //GABINETE HD (DEFEITO)
                    GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito") || GameObject.FindWithTag("GabineteCompletoHDDefeito") || GameObject.FindWithTag("GabineteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2HDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito") ||



                    //GABINETE FONTE HD
                    GameObject.FindWithTag("GabineteFonteHD") || GameObject.FindWithTag("GabineteMotherBoardFonteHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD") ||



                    
                    //GABINETE FONTE HD (DEFEITO)
                    GameObject.FindWithTag("GabineteFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoFonteHDDefeito")




                    /*
                    GameObject.FindWithTag("") || GameObject.FindWithTag("") || GameObject.FindWithTag("") ||
                    GameObject.FindWithTag("") || GameObject.FindWithTag("") || GameObject.FindWithTag("") ||
                    GameObject.FindWithTag("") || GameObject.FindWithTag("") || GameObject.FindWithTag("") ||
                    GameObject.FindWithTag("") || GameObject.FindWithTag("") || GameObject.FindWithTag("") ||
                    GameObject.FindWithTag("") ||*/
                    )
                {
                    print("ja tem");
                }

                else
                {
                    Instantiate(Gabinete, transform.position, transform.rotation);
                    transform.position = startPosition;
                }
            }

        } 
    }

    public void InstanciarProcessador()
    {
        if (Vector2.Distance(txtProcessador.transform.position, transform.position) > 100)
        {
            if (Input.GetMouseButtonUp(0))
            {
                //JUNCAO
                if (GameObject.FindWithTag("Processador") || GameObject.FindWithTag("MotherBoardProcessador") || GameObject.FindWithTag("MotherBoardProcessadorVideo") ||
                    GameObject.FindWithTag("MotherBoardRAM2Processador") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo") || GameObject.FindWithTag("MotherBoardRAMProcessador") ||
                    GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo") ||


                    //GABINETE
                    GameObject.FindWithTag("GabineteCompleto") || GameObject.FindWithTag("GabineteCompletoRAM1") || GameObject.FindWithTag("GabineteMotherBoardProcessador") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo") || GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessador") ||

                    //GABINETE COM FONTE
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte") ||

                    //GABINETE COM FONTE (DEFEITO)
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteDefeito") ||

                    //GABINETE DEFEITO
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2Processador") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito") || GameObject.FindWithTag("GabineteCompletoDefeito") || GameObject.FindWithTag("GabineteCompletoRAM1Defeito") ||

                    //GABINETE HD
                    GameObject.FindWithTag("GabineteCompleto1RAMHD") || GameObject.FindWithTag("GabineteCompletoHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD") ||

                    //GABINETE HD (DEFEITO)
                    GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito") || GameObject.FindWithTag("GabineteCompletoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito") ||

                    //GABINETE FONTE HD
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD") ||

                    //GABINETE FONTE HD (DEFEITO)
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito") ||
                
                    //JUNCAO DEFEITO
                    GameObject.FindWithTag("MotherBoardRAM2ProcessadorDefeito") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito") || GameObject.FindWithTag("MotherBoardRAMProcessadorDefeito") ||
                    GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito"))
                {
                    print("ja tem");
                }

                else
                {
                    Instantiate(Processador, transform.position, transform.rotation);
                    transform.position = startPosition;
                }
            }
        } 
    }

    public void InstanciarHD()
    {
        if (Vector2.Distance(txtHD.transform.position, transform.position) > 100)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (GameObject.FindWithTag("HD") || GameObject.FindWithTag("GabineteCompleto1RAMHD") || GameObject.FindWithTag("GabineteCompletoHD") ||
                    GameObject.FindWithTag("GabineteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2HD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD") || GameObject.FindWithTag("GabineteMotherBoardRAMHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD") || GameObject.FindWithTag("GabineteMotherBoardVideoHD") || GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD") ||
                    GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito") || GameObject.FindWithTag("GabineteCompletoHDDefeito") || GameObject.FindWithTag("GabineteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2HDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito") || GameObject.FindWithTag("GabineteFonteHD") || GameObject.FindWithTag("GabineteMotherBoardFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD") || GameObject.FindWithTag("GabineteFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHDDefeito")
                    )
                {
                    print("ja tem");
                }

                else
                {
                    Instantiate(HD, transform.position, transform.rotation);
                    transform.position = startPosition;
                }
            }
        } 
    }

    public void InstanciarVideoBoard()
    {
        if (Vector2.Distance(txtVideoBoard.transform.position, transform.position) > 100)
        {
            if (Input.GetMouseButtonUp(0))
            {
                //JUNCAO
                if (GameObject.FindWithTag("VideoBoard") || GameObject.FindWithTag("MotherBoardProcessadorVideo") || GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideo") ||
                    GameObject.FindWithTag("MotherBoardRAM2Video") || GameObject.FindWithTag("MotherBoardRAMPRocessadorVideo") || GameObject.FindWithTag("MotherBoardRAMVideo") ||
                    GameObject.FindWithTag("MotherBoardVideo") ||


                    //GABINETE
                    GameObject.FindWithTag("GabineteCompleto") || GameObject.FindWithTag("GabineteCompletoRAM1") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideo") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2Video") || GameObject.FindWithTag("GabineteMotherBoardRAMVideo") || GameObject.FindWithTag("GabineteMotherBoardVideo") ||


                    //GABINETE COM FONTE
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardVideoFonte") ||


                    //GABINETE COM FONTE (DEFEITO)
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteDefeito") ||

                    //GABINETE DEFEITO
                    GameObject.FindWithTag("GabineteCompletoDefeito") || GameObject.FindWithTag("GabineteCompletoRAM1Defeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMVideo") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoDefeito") ||


                    //GABINETE HD
                    GameObject.FindWithTag("GabineteCompleto1RAMHD") || GameObject.FindWithTag("GabineteCompletoHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMVideoHD") || GameObject.FindWithTag("GabineteMotherBoardVideoHD") || GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHD") ||


                    //GABINETE HD (DEFEITO)
                    GameObject.FindWithTag("GabineteCompleto1RAMHDDefeito") || GameObject.FindWithTag("GabineteCompletoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMVideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoProcessadorHDDefeito") ||


                    //GABINETE FONTE HD
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD") ||


                    //GABINETE FONTE HD (DEFEITO)
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHDDefeito") ||


                    //JUNCAO DEFEITO
                    GameObject.FindWithTag("MotherBoardRAM2ProcessadorVideoDefeito") || GameObject.FindWithTag("MotherBoardRAM2VideoDefeito") || GameObject.FindWithTag("MotherBoardRAMProcessadorVideoDefeito") ||
                    GameObject.FindWithTag("MotherBoardRAMVideoDefeito") || GameObject.FindWithTag("MotherBoardVideoDefeito")
                    )
                {
                    print("ja tem");
                }

                else
                {
                    Instantiate(VideoBoard, transform.position, transform.rotation);
                    transform.position = startPosition;
                }
            }
        } 
    }

    public void InstanciarFonte()
    {
        if (Vector2.Distance(txtFonte.transform.position, transform.position) > 100)
        {
            if (Input.GetMouseButtonUp(0))
            {
              if(GameObject.FindWithTag("Fonte") || GameObject.FindWithTag("FonteDefeito") || GameObject.FindWithTag("GabineteFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardFonte") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2Fonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonte") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonte") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonte") || GameObject.FindWithTag("GabineteMotherBoardVideoFonte") ||
                    GameObject.FindWithTag("GabineteFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardVideoFonteDefeito") || GameObject.FindWithTag("GabineteFonteHD") || GameObject.FindWithTag("GabineteMotherBoardFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHD") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHD") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHD") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHD") || GameObject.FindWithTag("GabineteFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2FonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAM2ProcessadorVideoFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAM2VideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorFonteHDDefeito") ||
                    GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardRAMVideoFonteHDDefeito") || GameObject.FindWithTag("GabineteMotherBoardVideoFonteHDDefeito"))
                {
                    print("ja tem");
                }

              else
                {
                    Instantiate(Fonte, transform.position, transform.rotation);
                    transform.position = startPosition;
                }
            }
        }
    }
}
