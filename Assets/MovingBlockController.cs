using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public float movementSpeed = 1f; // Geschwindigkeit der Bewegung
    private int direction = -1; // Richtung (1 oder -1)

    void Update()
    {
        // Bewege das Objekt horizontal basierend auf der aktuellen Richtung
        transform.Translate(Vector3.back * direction * movementSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Ändere die Richtung, wenn eine Kollision erkannt wird
        direction *= -1;
    }
}