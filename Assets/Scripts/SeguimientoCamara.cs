using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{
    public Transform objetoASeguir; // Referencia al objeto que quieres seguir
    public float distanciaZ = 10f; // Distancia en el eje Z entre la cámara y el objeto
    public float distanciaMinima = 50f; // Distancia mínima entre la cámara y el objeto

    // Puedes ajustar la velocidad de seguimiento según sea necesario
    public float velocidadSeguimiento = 2f;

    void Update()
    {
        if (objetoASeguir == null)
            return; // No hay nada que seguir, sal del método Update

        // Calculamos la posición deseada de la cámara
        Vector3 posicionDeseada = objetoASeguir.position + new Vector3(0, 0, distanciaZ);

        // Limitamos la distancia mínima entre la cámara y el objeto
        float distanciaActual = Vector3.Distance(transform.position, posicionDeseada);
        if (distanciaActual < distanciaMinima)
        {
            // Mantenemos la distancia mínima
            posicionDeseada = transform.position + (posicionDeseada - transform.position).normalized * distanciaMinima;
        }

        // Movemos la cámara hacia la posición deseada suavemente
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, velocidadSeguimiento * Time.deltaTime);
    }
}
