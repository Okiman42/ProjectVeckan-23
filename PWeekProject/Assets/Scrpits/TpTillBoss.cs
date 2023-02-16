using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TpTillBoss : MonoBehaviour
{
    
    public GameObject Dopp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Dopp)
        {
            SceneManager.LoadScene("main menu");
        }
    }
}
