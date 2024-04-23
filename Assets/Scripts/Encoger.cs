using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encoger : MonoBehaviour
{
    private Vector3 escala;

    void OnTriggerEnter(Collider other){
        escala = other.GetComponent<Renderer>().transform.localScale;
        other.GetComponent<Renderer>().transform.localScale = new Vector3(escala.x-5f, escala.y-5f, escala.z-5f);
    }
}
