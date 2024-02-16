using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Geschwindigkeit, mit der sich das Objekt bewegt

    void Update()
    {
        // Benutzereingaben abrufen
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Neue Position berechnen
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
