using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody2D player;
    public Camera cam;
    Vector2 move;
    Vector2 mousePos;
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveInp();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

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
}
