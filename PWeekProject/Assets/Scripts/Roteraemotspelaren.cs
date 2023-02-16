using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roteraemotspelaren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform target;
    public float speed = 1.0f;
    void Update()
    {
        Vector3 targetDirection = target.position - transform.position;

        float singelStep = speed * Time.deltaTime;

        Vector3 newDirction = Vector3.RotateTowards(transform.forward, targetDirection, singelStep, 0.0f);

        transform.rotation = Quaternion.LookRotation(newDirction);
    }
}
