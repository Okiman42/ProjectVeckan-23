using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Momentum2: MonoBehaviour
{
    
    public int speed;


    
    void Update()
    {

        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        this.transform.position += Movement * speed * Time.deltaTime;


    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}