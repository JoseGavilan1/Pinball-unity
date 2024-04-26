using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class AumentarVelocidad : MonoBehaviour
{
    Rigidbody rb;

    public float velocidad;
    
    public void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate(){
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        UnityEngine.Vector3 movimiento = new UnityEngine.Vector3(movimientoHorizontal,0,movimientoVertical);
        rb.AddForce(movimiento*velocidad);
    }
}
