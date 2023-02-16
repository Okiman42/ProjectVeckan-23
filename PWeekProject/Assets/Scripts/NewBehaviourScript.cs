using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public Rigidbody fire;
    public int bert = 2;
    

    void Update()
    {
        if(bert == 2)
        {

            Rigidbody attack;

            attack = Instantiate(fire, transform.position, transform.rotation);
            attack.velocity = transform.TransformDirection(Vector3.forward * 20);

            Thread.Sleep(2000);
            
        }
    }
    void FireAttack()
    {


    }
}
