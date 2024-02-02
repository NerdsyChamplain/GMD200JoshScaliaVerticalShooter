using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastTest : MonoBehaviour
{
    //this code adapted from following tutorial: https://www.youtube.com/watch?v=Tk6WfGfgrs4
    private LineRenderer lineRenderer;
    public Transform lasHit;
    public Transform player;
    //public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = true;
        lineRenderer.useWorldSpace = true;
        //lineRenderer.colorGradient = new Gradient(Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 100f, layerMask);
        Debug.DrawLine(transform.position, hit.point, Color.red);
        lasHit.position = hit.point;
        lineRenderer.SetPosition(0, player.position);
        lineRenderer.SetPosition(1, lasHit.position);
        //laser.transform.localScale
        
    }
}
