using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    void Start()
    {
        curHealth = maxHealth;
    }

    public GameObject bob;
    public GameObject sword;
    void Update()
    {
        
        if(curHealth == 0)
        {
            Destroy(bob);
        }
        if(curHealth == 0)
        {
            Thread.Sleep(200);
            SceneManager.LoadScene(4);
        }
    }
    public void DamageBoss(int damage)
    {
        curHealth -= damage;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == sword)
        {
            DamageBoss(10);
        }


    }


}
