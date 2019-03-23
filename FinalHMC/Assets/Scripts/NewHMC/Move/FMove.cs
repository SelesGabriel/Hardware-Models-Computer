using UnityEngine;
using System.Collections;

public class FMove : MonoBehaviour {

    float moveSpeed = 40.0f;
    float velocidade = 0.70f;
    float rotateSpeed = 60.0f;
	// Use this for initialization
	void Start () {
        Vector3 pos;
        pos = transform.position;

        pos.x = 11;
        pos.y = 12;
        pos.z = 11;

        transform.position = pos;
    }
	
	// Update is called once per frame
	void Update () {

        //LIMITAR CAMERA DENTRO DA TELA

        Vector3 clampedPosition = transform.position;
        
        clampedPosition.y = Mathf.Clamp(transform.position.y, 3, 26);
        clampedPosition.z = Mathf.Clamp(transform.position.z, -130, 22);
        clampedPosition.x = Mathf.Clamp(transform.position.x, -9, 33);
        transform.position = clampedPosition;

        //FIM

        //MOVE WASD
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidade);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidade);
        }

        //MOVE UP AND DOWN

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }

        //ROTATE CAMERA
        if (Input.GetKey(KeyCode.E))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0, 0.5f));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                transform.RotateAround(hit.point, Vector3.up, rotateSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0, 0.5f));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                transform.RotateAround(hit.point, -Vector3.up, rotateSpeed * Time.deltaTime);
            }
        }




	}
}
