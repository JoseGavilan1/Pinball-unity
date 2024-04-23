using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalizar : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
