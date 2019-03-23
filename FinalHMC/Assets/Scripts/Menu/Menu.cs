using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    float posX, posY, altura, largura;

    void Start()
    {
        altura = 50;
        largura = 50;
    }

    public void btnStart()
    {
        Application.LoadLevel("NewHMC");
    }

	public void btnFase1()
	{
		Application.LoadLevel ("FaseUM");
	}

	public void btnSair()
	{
		Application.Quit ();
	}

	public void btnCarregarMenu()
	{
		Application.LoadLevel ("Menu");
	}
    
}
