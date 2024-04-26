using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public Color nuevoColor = Color.red; // Color al que se cambiará la esfera al colisionar

    void OnCollisionEnter(Collision collision)
    {
        Renderer renderer = GetComponent<Renderer>(); // Obtener el Renderer de la esfera

        if (renderer != null)
        {
            renderer.material.color = nuevoColor; // Cambiar el color de la esfera
        }
    }
}
