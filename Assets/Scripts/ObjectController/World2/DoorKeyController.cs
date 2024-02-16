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

    private void Update()
    {
        transform.Rotate(new Vector3(0,30,0) * Time.deltaTime);
    }
}
