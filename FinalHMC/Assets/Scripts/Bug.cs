using UnityEngine;
using System.Collections;

public class FBug : MonoBehaviour {

    public GameObject gameObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
        
	}

    public void btnInstanciar()
    {
        Instantiate(gameObject);
    }
}
