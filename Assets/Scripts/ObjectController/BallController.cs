using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    private float movementX;
    private float movementY;

    private float startAccX = 0;
    private float startAccY = 0;

    public float speed = 1;

    private int score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // when move input is detected
    void OnMove(InputValue movementValue)
    {
        
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // called once per fixed frame-rate frame
    private void FixedUpdate()
    {
        Debug.Log("x: " + movementX.ToString() + " !!! y: "
    + movementY.ToString());

        // 3D movement vector 
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        if(movementX == 0 && movementY == 0)// @todo: verbessern 
        {
            if(startAccX == 0)
            {
                startAccX = Input.acceleration.x;
                startAccY = Input.acceleration.y;
            }
            movement = new Vector3(Input.acceleration.x - startAccX, 0.0f, Input.acceleration.y - startAccY);
            //rb.velocity = movement * speed;
        }

        // Apply force to the Rigidbody
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("GameEnd"))
        {
            //@todo temporary
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            rb.AddForce(90f, 0f, 90f);
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}
