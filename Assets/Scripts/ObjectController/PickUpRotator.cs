using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotator : MonoBehaviour
{

    private Vector3 offset;
    public float speedX = 0f;
    public float speedY = 0f;
    public float speedZ = 0f;

    void Start()
    {
        offset = new Vector3(speedX, speedY, speedZ);
    }
    
    // Update is called once per frame
    void Update()
    {
       transform.Rotate(speedX, speedY, speedZ);
    }
}
