using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDrag : MonoBehaviour {

    public float offsetX;
    public float offsetY;

    //public GameObject signSpot;

    public bool canDrag = true;

    public GameObject draggable;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseOver()
    {
        Debug.Log("Above the card");
    }

    public void BeginDrag()
    {
        if (canDrag)
        {
            offsetX = transform.position.x - Input.mousePosition.x;
            offsetY = transform.position.y - Input.mousePosition.y;
        }
       
    }

    public void OnDrag()
    {
        if (canDrag)
        {
            transform.position = new Vector3(offsetX + Input.mousePosition.x, offsetY + Input.mousePosition.y);
            Debug.Log("dragging");
        }
    }

    /*
    //this didn't work. It set canDrag to false as soon as I stopped dragging, whether or not symbol was in correct position
    public void OnTriggerEnter(GameObject other)
    {
        if(other.gameObject.tag == alchemySymbol.gameObject.tag)
        {
            canDrag = false;
        }
    }
    */

  
}
