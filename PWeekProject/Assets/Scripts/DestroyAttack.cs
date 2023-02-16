using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject attack;
    void Update()
    {
        Destroy(attack,2);
    }
}
