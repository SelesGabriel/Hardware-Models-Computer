using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class DragAndDropNotification : MonoBehaviour, IDragHandler {

    public GameObject itemDrag;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
}
