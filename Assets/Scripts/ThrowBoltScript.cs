using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBoltScript : MonoBehaviour
{
    public GameObject bolt;

    public float castSpeed;

    private void Start()
    {
        StartCoroutine(ThrowBolt());
    }

    private IEnumerator ThrowBolt()
    {
        while (true)
        {
            yield return new WaitForSeconds(castSpeed);
            Instantiate(bolt, transform.position, transform.rotation);
        }
    }
}
