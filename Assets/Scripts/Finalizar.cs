using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Finalizar : MonoBehaviour
{
    public GameObject objetoFinalizador; // Objeto que finaliza la aplicación

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == objetoFinalizador)
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
