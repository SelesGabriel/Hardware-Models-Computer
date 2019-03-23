using UnityEngine;
using System.Collections;


public class Position : MonoBehaviour
{
    public GameObject MotherBoard;
    Vector3 pos;
    public bool ativado;

    // Use this for initialization
    public void Start()
    {



        if (gameObject.tag == "MotherBoard")
        {
            pos = transform.position;
            transform.Rotate(0, 0, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 19;

            transform.position = pos;

        }



        if (gameObject.tag == "RAM")
        {
            pos = transform.position;
            transform.Rotate(0, 0, 0);
            pos.x = 2;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

        if (gameObject.tag == "RAMDefeito")
        {
            pos = transform.position;
            transform.Rotate(0, 0, 0);
            pos.x = 2;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }


        if (gameObject.tag == "Gabinete")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            pos.x = 6;
            pos.y = 11;
            pos.z = 23;

            transform.position = pos;
        }

        if (gameObject.tag == "VideoBoard")
        {
            pos = transform.position;
            transform.Rotate(0, 0, 0);
            pos.x = 10;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

        if (gameObject.tag == "Processador")
        {
            pos = transform.position;
            transform.Rotate(0, 0, 0);
            pos.x = 12;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

        if (gameObject.tag == "HD")
        {
            
            pos = transform.position;
            transform.Rotate(0, 0, 0);
            pos.x = 14;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

        if(gameObject.tag == "Fonte")
        {
            pos = transform.position;
            
            pos.x = 6;
            pos.y = 8;
            pos.z = 19;

            transform.position = pos;
        }


        //PLACA MÃE
        if (gameObject.tag == "MotherBoardProcessador")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;

        }

        if (gameObject.tag == "MotherBoardVideo")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

        if (gameObject.tag == "MotherBoardRAM")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

		if (gameObject.tag == "MotherBoardRAMDefeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

        if (gameObject.tag == "MotherBoardRAM2")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

		if (gameObject.tag == "MotherBoardRAM2Defeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

        if (gameObject.tag == "MotherBoardRAMProcessador")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

		if (gameObject.tag == "MotherBoardRAMProcessadorDefeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

        if (gameObject.tag == "MotherBoardRAMVideo")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

		if (gameObject.tag == "MotherBoardRAMVideoDefeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

        if (gameObject.tag == "MotherBoardProcessadorVideo")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

        if (gameObject.tag == "MotherBoardRAM2Processador")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

		if (gameObject.tag == "MotherBoardRAM2ProcessadorDefeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

        if (gameObject.tag == "MotherBoardRAM2Video")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

		if (gameObject.tag == "MotherBoardRAM2VideoDefeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

        if (gameObject.tag == "MotherBoardRAM2ProcessadorVideo")
        {
            pos = transform.position;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x = 17;
            pos.y = 8;
            pos.z = 20;

            transform.position = pos;
        }

		if (gameObject.tag == "MotherBoardRAM2ProcessadorVideoDefeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

		if (gameObject.tag == "MotherBoardRAMPRocessadorVideo")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

		if (gameObject.tag == "MotherBoardRAMProcessadorVideoDefeito")
		{
			pos = transform.position;
			transform.rotation = Quaternion.Euler(0, 180, 0);
			pos.x = 17;
			pos.y = 8;
			pos.z = 20;

			transform.position = pos;
		}

		//MOTHERBOARD DEFEITO




        //GABINETE

        if (GameObject.FindWithTag("GabineteMotherBoard"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardDefeito"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMDefeito"))
        {

        }

        if(GameObject.FindWithTag("GabineteMotherBoardVideo"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardVideoDefeito"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessador"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorDefeito"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2")) //FALTA FAZER PREFAB
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAM2Defeito")) // FALTA FAZER PREFAB
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessador"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMProcessadorDefeito"))
        {

        }

        if (GameObject.FindWithTag("GaineteMotherBoardProcessadorVideo"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardProcessadorVideoDefeito"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideo"))
        {

        }

        if (GameObject.FindWithTag("GabineteMotherBoardRAMVideoDefeito"))
        {

        }

        if (GameObject.FindWithTag("GabineteCompletoRAM1"))
        {

        }

        if (GameObject.FindWithTag("GabineteCompletoRAM1Defeito"))
        {

        }

        if (GameObject.FindWithTag("GabineteCompleto"))
        {

        }

        if (GameObject.FindWithTag("GabineteCompletoDefeito")) //FALTA FAZER PREFAB
        {

        }
    }

    // Update is called once per frame
    void Update()
    {


    }


}
