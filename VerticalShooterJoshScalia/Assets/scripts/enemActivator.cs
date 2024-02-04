using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemActivator : MonoBehaviour
{
    public GameObject enem1, enem2;
    public Transform spawn1, spawn2;
    private bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canSpawn == true && collision.tag!= "playBul")
        {
            if(collision.tag != "enemBul")
            {
                GameObject spawnedEnem = Instantiate(enem1 , spawn1.position, spawn1.rotation);
                GameObject spawnedEnem2 = Instantiate(enem2, spawn2.position, spawn2.rotation);
                spawnedEnem.SetActive(true);
                spawnedEnem2.SetActive(true);
                canSpawn = false;
            }
           
        }
        
    }
}
