using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManager : MonoBehaviour
{
    public string nextScene;
    public string winScreen;
    public string deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
    public void winScene()
    {
        SceneManager.LoadScene(winScreen);
    }
    public void deathScene()
    {
        SceneManager.LoadScene(deathScreen);
    }
}
