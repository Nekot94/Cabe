using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivasikSkript : MonoBehaviour {

    public float invTime = 10f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HeroScript heroScript = collision.gameObject.GetComponent<HeroScript>();
            heroScript.MakeInvincible(invTime);
            Destroy(gameObject);
            


        }
    }

    
}
