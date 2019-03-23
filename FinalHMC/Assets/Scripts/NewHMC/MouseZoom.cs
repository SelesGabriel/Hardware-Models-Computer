using UnityEngine;
using System.Collections;

public class MouseZoom : MonoBehaviour {
    float velocidade = 0.5f;
    private float desiredDistance;
    public int zoomRate = 40;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            //GetComponent<Camera>().fieldOfView--;
            transform.Translate(0, 0, velocidade);
            //GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - .3f, transform.position.z + .3f);
            
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //GetComponent<Camera>().fieldOfView++;
            transform.Translate(0, 0, -velocidade);
        }
    }
}
