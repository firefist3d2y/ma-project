using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ball GameObject.
    public GameObject ball;

    // distance between camera and player
    private Vector3 offset;

    // called before the first frame update.
    void Start()
    {
        // offset between camera player
        offset = transform.position - ball.transform.position;
    }

    // called once per frame after all Update functions 
    void LateUpdate()
    {
        // Maintain the same offset between the camera and player
        transform.position = ball.transform.position + offset;
    }
}