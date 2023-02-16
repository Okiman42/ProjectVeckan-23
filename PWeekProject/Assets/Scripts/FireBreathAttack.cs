using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBreathAttack : MonoBehaviour
{
    public Transform spawnPosition;
    public Rigidbody2D fireAttack;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D fireBreath;
            fireBreath = Instantiate(fireAttack, spawnPosition.position, spawnPosition.rotation);
        }
    }
}
