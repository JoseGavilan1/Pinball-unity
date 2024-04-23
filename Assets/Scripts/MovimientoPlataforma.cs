using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimientoPlataforma : MonoBehaviour
{
    private Vector3 posicion_inicial;
    private Vector3 posicion_max;
    private Vector3 posicion_min;
    private float recorrido;
    // Start is called before the first frame update
    void Start()
    {
        posicion_inicial = transform.position;
        posicion_max = new Vector3(posicion_inicial.x,posicion_inicial.y,posicion_inicial.z+5);
        posicion_min = new Vector3(posicion_inicial.x,posicion_inicial.y,posicion_inicial.z-5);
        recorrido = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= posicion_max.z){
            recorrido = -0.01f;
        }
        else if(transform.position.z <= posicion_min.z){
            recorrido = 0.01f;
        }
        transform.Translate(0,0,recorrido);
        
    }
}
