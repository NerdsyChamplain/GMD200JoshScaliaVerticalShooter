using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemSpawnWave : MonoBehaviour
{
    public GameObject wall;
    public GameObject enem1, enem2;
    public Transform spawn1, spawn2, spawn3, spawn4, spawn5, spawn6, spawn7, spawn8, spawn9, spawn10, spawn11, spawn12, spawn13, spawn14, spawn15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "playBul")
        {
            if (collision.tag != "enemBul")
            {
                wall.SetActive(true);
            }
        }
    }
    private IEnumerator spawnDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        
    }
}
