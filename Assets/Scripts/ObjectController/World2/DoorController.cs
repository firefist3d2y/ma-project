using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController2 : OpenableObject
{
    [Range(0f, 4f)]
    [Tooltip("Speed for door opening, degrees per sec")]
    public float OpenSpeed = 3f;

    // Hinge
    [HideInInspector]
    public Rigidbody rbDoor;
    HingeJoint hinge;
    JointLimits hingeLim;
    float currentLim;

    //eigenes
    float targetLim = 0;
    [Tooltip("side to wich the door should open")]
    public bool openSide = true;

    override
    protected void openObject()
    {
        if(openSide)
        {
            targetLim = 85f;
        }
        else
        {
            targetLim = -85f;
        }
    }

    override
    protected void closeObject()
    {
        targetLim = 0f;
    }

    void Start()
    {
        rbDoor = GetComponent<Rigidbody>();
        hinge = GetComponent<HingeJoint>();
    }
    

    //used original idea by moving door with hinge limits but used own implementation
    private void FixedUpdate() // door is physical object
    {
        if(currentLim < targetLim - .5f)
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
    }
}
