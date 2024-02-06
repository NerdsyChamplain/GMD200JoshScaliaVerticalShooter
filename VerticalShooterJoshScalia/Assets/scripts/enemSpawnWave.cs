using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enemSpawnWave : MonoBehaviour
{
    public GameObject wall;
    public GameObject enem1, enem2;
    public Transform spawn1, spawn2, spawn3, spawn4, spawn5, spawn6, spawn7, spawn8, spawn9, spawn10, spawn11, spawn12, spawn13, spawn14, spawn15;
    private int randSpawnPos, randEnem;
    private bool hasActivated, isTiming;
    private int surviveTimeGoal;
    public sceneManager vicScene;
    public TextMeshProUGUI timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        hasActivated = false;
        surviveTimeGoal = 30;
        isTiming = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTiming == true)
        {
            timeLeft.text = "Survive, Time remaining: " + surviveTimeGoal.ToString();
        }
        randSpawnPos = Random.Range(1, 16);
        randEnem = Random.Range(1, 3);
        if(surviveTimeGoal <= 0)
        {
            vicScene.winScene();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "playBul" && hasActivated == false)
        {
            if (collision.tag != "enemBul")
            {
                wall.SetActive(true);
                hasActivated = true;
                StartCoroutine(spawnDelay(1f));
                StartCoroutine(timer(1));
                isTiming = true;
            }
        }
    }
    private IEnumerator timer(int delay)
    {
        yield return new WaitForSeconds(delay);
        surviveTimeGoal -= delay;
        StartCoroutine(timer(delay));
    }
    private IEnumerator spawnDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        spawn();
        StartCoroutine(spawnDelay(delay));
        
    }
    private void spawn()
    {
        switch(randSpawnPos)
        {
            case 1:
                if(randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn1.position, spawn1.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn1.position, spawn1.rotation);
                }
                break;
            case 2:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn2.position, spawn2.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn2.position, spawn2.rotation);
                }
                break;
            case 3:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn3.position, spawn3.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn3.position, spawn3.rotation);
                }
                break;
            case 4:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn4.position, spawn4.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn4.position, spawn4.rotation);
                }
                break;
            case 5:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn5.position, spawn5.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn5.position, spawn5.rotation);
                }
                break;
            case 6:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn6.position, spawn6.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn6.position, spawn6.rotation);
                }
                break;
            case 7:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn7.position, spawn7.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn7.position, spawn7.rotation);
                }
                break;
            case 8:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn8.position, spawn8.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn8.position, spawn8.rotation);
                }
                break;
            case 9:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn9.position, spawn9.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn9.position, spawn9.rotation);
                }
                break;
            case 10:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn10.position, spawn10.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn10.position, spawn10.rotation);
                }
                break;
            case 11:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn11.position, spawn11.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn11.position, spawn11.rotation);
                }
                break;
            case 12:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn12.position, spawn12.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn12.position, spawn12.rotation);
                }
                break;
            case 13:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn13.position, spawn13.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn13.position, spawn13.rotation);
                }
                break;
            case 14:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn14.position, spawn14.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn14.position, spawn14.rotation);
                }
                break;
            case 15:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn15.position, spawn15.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn15.position, spawn15.rotation);
                }
                break;
            default:
                if (randEnem == 1)
                {
                    GameObject newEnem = Instantiate(enem1, spawn1.position, spawn1.rotation);
                    newEnem.SetActive(true);
                }
                else
                {
                    GameObject newEnem = Instantiate(enem2, spawn1.position, spawn1.rotation);
                }
                break;
        }
    }
}
