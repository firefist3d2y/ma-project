using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampController : OpenableObject
{
    [Range(0f, 4f)]
    [Tooltip("Speed for door opening, degrees per sec")]
    public float OpenSpeed = 3f;


    public Rigidbody rbRamp;

    //eigenes
    [Tooltip("Distance wich the Ramp should move")]
    public float moveDist = 0f;

    float targetDist = 0;

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

    void Start()
    {
        rbRamp = GetComponent<Rigidbody>();
    }
    /*
    private void FixedUpdate()
    {
        if (currentLim < targetLim - .5f)
        {
            Debug.Log("targ gross " + targetLim + " curr: " + currentLim);
            currentLim += .5f * OpenSpeed;
        }
        else if (currentLim > targetLim + .5f)
        {
            Debug.Log("targ kleiner " + targetLim + " curr: " + currentLim);

            currentLim -= .5f * OpenSpeed;
        }

        // using values to door object
        hingeLim.max = currentLim + .5f;
        hingeLim.min = currentLim - .5f;
        hinge.limits = hingeLim;
    }*/
}
