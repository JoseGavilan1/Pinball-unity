using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agrandar : MonoBehaviour
{
    private Vector3 escala;

    void OnTriggerEnter(Collider other){
        escala = other.GetComponent<Renderer>().transform.localScale;
        other.GetComponent<Renderer>().transform.localScale = new Vector3(escala.x+200f, escala.y+200f, escala.z+200f);
    }
}
