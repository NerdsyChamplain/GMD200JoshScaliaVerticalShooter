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
    private bool isRun, canShoot;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        isRun = false;
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rotDirection = player.transform.position - transform.position;
        rotDirection.Normalize();
        float rotAngle = Mathf.Atan2(rotDirection.y, rotDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * rotAngle);
        if(isRun == false && canShoot == true)
        {
            isRun = true;
            canShoot = false;
            StartCoroutine(bulletDelay(1.5f));
        }
        

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
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _rb.AddForce(direction * veloc);
    }
    private IEnumerator bulletDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        isRun = false;
        canShoot = true;
        shoot(120);
    }
}
