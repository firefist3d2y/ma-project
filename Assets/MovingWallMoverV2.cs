using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWallMoverV2 : MonoBehaviour
{
    private float startX;
    private float startY;
    private float startZ;
    private Dictionary<string, bool> axis;
    public bool useX;
    public bool useY;
    public bool useZ;
    public float speed = 1;
    public float distance = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
        startZ = transform.position.z;  
        axis = new Dictionary<string, bool>();
        axis.Add("X", useX);
        axis.Add("Y", useY);
        axis.Add("Z", useZ);
        if (useX)
        {
            useY = false;
            useZ = false;
        } else if (useY)
        {
            useX = false;
            useZ = false;
        }
        else
        {
            useY = false;
            useX = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (useX)
        {
            if(transform.position.x < startX - distance || transform.position.x > startX + distance)
            {
                speed *= -1;
            }
            transform.Translate(new Vector3(speed, 0f, 0f) * Time.deltaTime);
        } else if (useY)
        {
            if (transform.position.y < startY - distance || transform.position.y > startY + distance)
            {
                speed *= -1;
            }
            transform.Translate(new Vector3(0f, speed, 0f) * Time.deltaTime);
        }
        else
        {
            if (transform.position.z < startZ - distance || transform.position.z > startZ + distance)
            {
                speed *= -1;
            }
            transform.Translate(new Vector3(speed, 0f, 0f) * Time.deltaTime);
        }
    }
}
