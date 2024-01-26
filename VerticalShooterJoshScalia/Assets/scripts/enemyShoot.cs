using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    private float maxHealth = 2;
    private float curHealth;
    public GameObject player;
    private float shotTarget;
    public GameObject enemBullet;
    public Transform shotPoint;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(bulletDelay(0.5f));

    }
    public void takeHit(float damage)
    {
        curHealth -= damage;
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void shoot(float veloc)
    {
        GameObject enemBul = Instantiate(enemBullet, shotPoint.position, shotPoint.rotation);
        Rigidbody2D _rb = enemBul.GetComponent<Rigidbody2D>();
        _rb.AddForce(enemBul.transform.forward * veloc);
    }
    private IEnumerator bulletDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        shoot(20);
    }
}
