using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyController2 : OpeningObject
{
    override
    protected void OnCollisionEnter(Collision collision)
    {
        toggle();
        Destroy(gameObject);
    }
}
