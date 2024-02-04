using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float damage = 1f;
    public GameObject destroyEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(destroyEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "enemSpawn")
        {
            GameObject explode = Instantiate(destroyEffect, transform.position, transform.rotation);
            Destroy(gameObject);        
            enemyRushMove rushEnem = collision.GetComponent<enemyRushMove>();
            if(rushEnem != null)
            {
                //implement checking hp in order to add score once that is a feature
                rushEnem.takeHit(damage);
            }
            enemBullet enemyBul = collision.GetComponent<enemBullet>();
            if(enemyBul != null) //&& enemyBul.tag == "enemBul")
            {
                enemyBul.removeBul();
            }
            enemyShoot shotEnem = collision.GetComponent<enemyShoot>();
            if(shotEnem != null)
            {
                shotEnem.takeHit(damage);
            }
        }
    }

}
