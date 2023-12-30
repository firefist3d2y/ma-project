using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dBallMovmentScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Geschwindigkeit, mit der sich das Objekt bewegt

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Benutzereingaben abrufen
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Neue Position berechnen
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}

