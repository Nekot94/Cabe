using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnMouse : MonoBehaviour
{

    private Rigidbody2D myBody;

    public float speed;

	void Start ()
    {
        myBody = GetComponent<Rigidbody2D>();
	}

	void Update ()
    {
        if (!Input.GetMouseButton(0))
            return;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 destination = Vector3.MoveTowards(transform.position, mousePos, speed);
        myBody.MovePosition(new Vector2(destination.x, destination.y));
	}
}
