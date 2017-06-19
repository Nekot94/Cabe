using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D myBody;
    

	void Start ()
    {
        myBody = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVertical = Input.GetAxis("Vertical") * speed;
        myBody.AddForce(new Vector2(moveHorizontal, moveVertical));

    }
}
