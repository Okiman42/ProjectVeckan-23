using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAttack : MonoBehaviour
{
    public GameObject attack;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(attack,3);
    }

    
}