using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBounce : MonoBehaviour {

    [SerializeField]
    private float speedX;
    [SerializeField]
    private float speedY;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "VerticalEdge")
        {
            Debug.Log("vertical hit");
            speedX = -speedX;
        }
        if (Other.gameObject.tag == "HorizontalTag")
        {
            Debug.Log("horizontal hit");
            speedY = -speedY;
        }
        if (Other.gameObject.tag == "Sprite")
        {
            Debug.Log("sprite hit");
            speedX = -speedX;
            speedY = -speedY;
        }
    }

    // Update is called once per frame
    void Update () {
        rb.velocity = new Vector2(speedX, speedY);
    }
}
