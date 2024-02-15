using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockGateScript : MonoBehaviour
{
    public KeyScript key; // type of used key

    //private void OnTriggerEnter(Collider other)
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && key.getIsCollected())
        {
            gameObject.SetActive(false);
            key.gameObject.SetActive(false);
        }
    }
}
