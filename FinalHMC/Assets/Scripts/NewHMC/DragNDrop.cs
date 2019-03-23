using UnityEngine;
using System.Collections;



public class DragNDrop : MonoBehaviour
{

    float distance = 7;

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y+5, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;


    }


}
