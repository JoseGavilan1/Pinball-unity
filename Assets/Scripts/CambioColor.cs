using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Renderer renderer = other.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.SetColor("_Color", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
        }
    }
}