using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public Rigidbody fire;
    public int bert = 2;


    void Update()
    {
        FireAttack();
    }

    float cooldown;
    

    public void FireAttack()
    {
        

        cooldown += Time.deltaTime;

        if (cooldown >= 1)
        {
            Rigidbody attack;

            attack = Instantiate(fire, transform.position, transform.rotation);
            attack.velocity = transform.TransformDirection(Vector3.forward * 10);

            cooldown = 0;
        }


    }
    


}
