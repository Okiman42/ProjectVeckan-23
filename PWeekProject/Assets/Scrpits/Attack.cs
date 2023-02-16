using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int speed;


    public GameObject boss;
        
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {

            transform.Rotate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
            
        }

        


    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == boss)
        {
            Debug.Log("bob");
        }

    }
}
