using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D myBody;

    public int scores = 0;

    public bool isDead = false;

    public bool invincible = false;
    

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gem")
        {
            scores++;
            Destroy(collision.gameObject);
            Debug.Log(scores);
        }
    }

    public void MakeInvincible(float time)
    {
        StartCoroutine(StartInvincible(time));
    }

    private IEnumerator StartInvincible(float time)
    {
        invincible = true;
        GetComponent<SpriteRenderer>().material.color = Color.green;

        yield return new WaitForSeconds(time);
        invincible = false;
        GetComponent<SpriteRenderer>().material.color = Color.white;

    }

}
