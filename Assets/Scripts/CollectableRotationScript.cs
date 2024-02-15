using UnityEngine;

public class PermanentRotationScript : MonoBehaviour
{
    public float rotationSpeed = 30f; // Geschwindigkeit der Rotation

    void Update()
    {
        // Drehe das Objekt um die horizontale Achse
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}