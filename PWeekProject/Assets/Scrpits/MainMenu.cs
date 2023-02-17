using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        
        m_YourFirstButton.onClick.AddListener(delegate { PlayButton(); });
        m_YourSecondButton.onClick.AddListener(() => QuitButton());
       
    }


    void PlayButton()
    {
        //Output this to console when the Button2 is clicked
        SceneManager.LoadScene("Starten");
        Debug.Log("play");
    }

    void QuitButton()
    {
        //Output this to console when the Button3 is clicked
        Application.Quit();
        Debug.Log("proceeds to crash");
    }






    /*[SerializeField]
    private Button button;

    void Start()
    {
        this.button.onClick.AddListener(QuitButton);
    }

    private void QuitButton()
    {
        Application.Quit();
        Debug.Log("RAAAAAA");
    }*/
}
