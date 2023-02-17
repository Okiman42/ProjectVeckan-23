using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TpTillBoss : MonoBehaviour
{
    
    public GameObject Dopp;

    private void OnTriggerEnter(Collider other)
    {
        
            SceneManager.LoadScene("main menu");
        
    }
}
