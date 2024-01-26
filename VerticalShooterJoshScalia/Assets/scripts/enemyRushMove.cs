using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyRushMove : MonoBehaviour
{
    private float maxHealth = 2;
    private float curHealth;
    public GameObject player;
    public float speed;
    private float target;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    float getCurHealth()
    {
        return curHealth;
    }
    private void move()
    {
        //this movement code was taken from a previous group project and was made by Nicholas Mastrangelo, he gave me verbal permission to utilize it
        //I made minor adjustments for use in this project
        target = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }
    public void takeHit(float damage)
    {
        curHealth -= damage;
        if(curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
