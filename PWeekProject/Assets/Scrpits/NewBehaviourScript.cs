using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject sphere;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
             Instantiate(sphere, new Vector3(1, 1, 1), Quaternion.identity);

            GameObject clone;

            clone = Instantiate(sphere, transform.position, transform.rotation);

            
            

        }
    }
}
