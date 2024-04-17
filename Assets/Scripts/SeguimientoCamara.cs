using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ballTransform;
    public Vector3 offset = new Vector3(0f, 2f, -10f); // Modifica estos valores según sea necesario

    void Start()
    {
        if (ballTransform == null)
        {
            Debug.LogWarning("No se ha asignado el Transform de la pelota en el script de seguimiento de la cámara.");
        }
    }

    void LateUpdate()
    {
        if (ballTransform != null)
        {
            Vector3 desiredPosition = ballTransform.position + offset;
            transform.position = desiredPosition;
        }
    }
}
