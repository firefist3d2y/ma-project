using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : OpenableObject
{
    [Range(0f, 4f)]
    [Tooltip("Speed for Gate opening")]
    public float OpenSpeed = 3f;


    //eigenes
    [Tooltip("Distance wich the Gate should move")]
    public float moveDist = 3f;

    private float targetDist = 0f;

    override
    protected void openObject()
    {
        targetDist =-moveDist;
    }

    override
    protected void closeObject()
    {
        targetDist = +moveDist;
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
