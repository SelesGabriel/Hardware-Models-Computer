using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitarObjetos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 clampedPosition = transform.position;

        clampedPosition.y = Mathf.Clamp(transform.position.y, 2, 26);
        clampedPosition.z = Mathf.Clamp(transform.position.z, -130, 23);
        clampedPosition.x = Mathf.Clamp(transform.position.x, -13, 34.7f);
        transform.position = clampedPosition;
    }
}
