using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void removeBul()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        playerMove player = collision.GetComponent<playerMove>();
        if (player != null)
        {
            player.healthAdj(1f);
        }
    }

    
}
