using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{


    void Update()
    {
        
        (gameObject.GetComponent<Button>().onClick).AddListener(QuitButton);

    }

    private void QuitButton()
    {
        Application.Quit();
        Debug.Log("RAAAAAA");
    }
}
