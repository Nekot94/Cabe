using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemyScript : MonoBehaviour {

    public GameObject spawnObject;
    public GameObject spawnField;

    public int count;
    public float spawnTime;

    private float offset;
    private float x, y;
    private float maxX, maxY;

    public int health;

    void Start()
    {
        SpriteRenderer spawnFieldSprite = spawnField.GetComponent<SpriteRenderer>();
        BoxCollider2D fieldCollider = spawnField.GetComponent<BoxCollider2D>();
        SpriteRenderer itemSprite = spawnObject.GetComponent<SpriteRenderer>();
        offset = Mathf.Min(fieldCollider.size.x, fieldCollider.size.y) +
            Mathf.Max(itemSprite.sprite.bounds.size.x, itemSprite.sprite.bounds.size.y) / 2;
        maxX = spawnFieldSprite.sprite.bounds.size.x / 2 - offset;
        maxY = spawnFieldSprite.sprite.bounds.size.y / 2 - offset;
        StartCoroutine(SpawnPerTime());
    }


    private IEnumerator SpawnPerTime()
    {
        while (true){
            Spawn(count);
            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void Spawn(int count)
    {
        for (int i = 0; i < count; i++)
        {
            x = Random.Range(-maxX, maxX);
            y = Random.Range(-maxY, maxY);

            Instantiate(spawnObject, new Vector3(x, y, 0), Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            health--;
            if (health <= 0)
                Destroy(gameObject);
        }
        
    }
}
