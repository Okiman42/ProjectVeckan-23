using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class RotationTowardsPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Transform player;
    public float rotateSpeed = 1.0f;
    void Update()
    {
        Vector3 targetDirection = player.position - transform.position;
        float singelStep = rotateSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singelStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
