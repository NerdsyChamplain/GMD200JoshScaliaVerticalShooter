using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class playerMove : MonoBehaviour
{
    private Rigidbody2D player;
    public Camera cam;
    Vector2 move;
    Vector2 mousePos;
    public float speed = 2.5f;
    private float curHealth, maxHealth, adjHealth;
    public sceneManager sceneSwitcher;
    public Image healthBar;
    public TextMeshProUGUI healthNum;



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        maxHealth = 8;
        curHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        MoveInp();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        healthBar.fillAmount = curHealth / 10;
        adjHealth = curHealth / 2;
        healthNum.text = "Health: " + adjHealth.ToString();
    }
    private void FixedUpdate()
    {
        player.MovePosition(player.position + move * speed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - player.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        player.rotation = angle;
    }
    void MoveInp()
    {
        //adjust the movement values for use elsewhere
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

    }
    public void healthAdj(float damage)
    {
        curHealth -= damage;
        if(curHealth <= 0)
        {
            sceneSwitcher.deathScene();
        }
    }
}
