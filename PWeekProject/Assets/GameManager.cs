using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{





    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "main menu")
        {
            Debug.Log("mainmenu");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Scene()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
        SceneManager.LoadScene(currentScene.name);

        if (sceneName == "main menu")
        {
            //SceneManager.LoadScene("");
            Debug.Log("penis1");
        }
        /*else if (sceneName == "")
        {
            SceneManager.LoadScene("");
        }*/
    }
}
