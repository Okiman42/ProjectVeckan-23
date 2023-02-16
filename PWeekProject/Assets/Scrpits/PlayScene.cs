using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScene : MonoBehaviour
{


    void Update()
    {

        (gameObject.GetComponent<Button>().onClick).AddListener(PlayButton);

    }

    private void PlayButton()
    {
        SceneManager.LoadScene("scene1");
        Debug.Log("DRAG-deeznuts");
    }
}
