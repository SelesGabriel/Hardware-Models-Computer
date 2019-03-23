using UnityEngine;
using System.Collections;

public class Bug : MonoBehaviour {
    public GameObject obj;
    GameObject RAM;
	// Use this for initialization
	void Start () {
        RAM = GameObject.FindWithTag("RAM");
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(obj.transform.position, transform.position) < 10)
        {
            Instantiate(obj,transform.position, transform.rotation);
        }
	}
}
