using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public Transform shotPoint;
    public GameObject bullet;
    private bool bulletFired = false;
    // Start is called before the first frame update
    void Start()
    {
        bulletFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        //This will be the shooting code, I will use a coroutine if bulletfired is true then set it to false to make shooting speed set
        while(bulletFired == false)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject bulletNew = Instantiate(bullet, shotPoint.position, shotPoint.rotation);
                Rigidbody2D _rb = bulletNew.GetComponent<Rigidbody2D>();
                //note to self, when implementing enemy bullets use _rb.AddForce(bulletNew.transform.up * 20);
                _rb.AddForce(bulletNew.transform.up * 200);
                bulletFired = true;
            }
            
        }
        //start a coroutine to set bulletFired to false again
        if(bulletFired == true)
        {

        }
        
    }
}
