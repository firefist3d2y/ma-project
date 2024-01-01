using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    private float movementX;
    private float movementY;

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
        // 3D movement vector 
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        // Apply force to the Rigidbody
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}
