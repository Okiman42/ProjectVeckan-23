using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour
{

    int startkey = 0;

    void Start()
    {
        
    }

    
    void Update()
    {


        

        if  (startkey == 0)
        {
           

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                EventSystem.current.SetSelectedGameObject(
                         this.gameObject);
                startkey++;
            }
            
            //Debug.Log(startkey);
        }
        

       
    }
}
