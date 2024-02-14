using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampController : OpenableObject
{
    [Range(0f, 4f)]
    [Tooltip("Speed for door opening, degrees per sec")]
    public float OpenSpeed = 3f;


    //eigenes
    [Tooltip("Distance wich the Ramp should move")]
    public float moveDist = 0f;

    private float targetDist = 0f;

    override
    protected void openObject()
    {
        targetDist = moveDist;
    }

    override
    protected void closeObject()
    {
        targetDist = -moveDist;
    }

    
    private void FixedUpdate()
    {
        if (targetDist < -.05f)
        {
            targetDist += .005f * OpenSpeed;
            transform.position = transform.position + new Vector3(0, -.005f * OpenSpeed, 0);
        }
        else if (targetDist > .05f)
        {
            targetDist -= .005f * OpenSpeed;
            transform.position = transform.position + new Vector3(0, .005f * OpenSpeed, 0);
        }
    }
}
