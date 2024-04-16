using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarVelocidad : MonoBehaviour
{
    public Rigidbody rb;
    public float extraForce = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Si quieres aumentar la velocidad en algún momento:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * extraForce, ForceMode.Impulse);
        }
    }
}

