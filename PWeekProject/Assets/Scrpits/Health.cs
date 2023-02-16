using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public int curHealth = 0;
    public int maxHealth = 30;
    void Start()
    {
        curHealth = maxHealth;
    }

    public GameObject player;
    public GameObject bob;
    public GameObject lime;
    public GameObject noob;
    public GameObject nej;
    public GameObject Fire;


    void Update()
    {

        if (curHealth == 0)
        {
            Destroy(player);

        }
        if (curHealth == 20)
        {
            Destroy(lime);
        }
        if (curHealth == 10)
        {
            Destroy(noob);
        }
        if (curHealth == 0)
        {
            Destroy(nej);
        }
        if (curHealth == 0)
        {
            Thread.Sleep(200);
            SceneManager.LoadScene(2);

        }

    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == bob)
        {
            DamagePlayer(10);

        }
        if(other.gameObject == Fire)
        {
            DamagePlayer(10);
        }


    }
}
