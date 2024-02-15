using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//@todo: genereller machen
public class MovingWallMover : MonoBehaviour
{
    public float speed = 1;
    private float startPosZ;


    // Start is called before the first frame update
    void Start()
    {
        startPosZ = transform.position.z;
    }

    // Update is called once per frame

    void Update()
    {
        if (transform.position.z > startPosZ + 2.3 || transform.position.z < startPosZ - 2.3)
        {
            speed *= -1;
        }
        transform.Translate(new Vector3(0f, 0f, speed) * Time.deltaTime);

    }

    public void OnCollisionEnter(Collision collision)
    {
        speed *= -1;
        transform.Translate(new Vector3(0f, 0f, speed) * Time.deltaTime);
    }
}
