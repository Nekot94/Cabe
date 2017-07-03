using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBallScript : MonoBehaviour {

    public float frozenTime;
    public float frozenPower;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<HeroScript>().FreezeMe(
                frozenTime, frozenPower);
            Destroy(gameObject);


        }
    }

}
