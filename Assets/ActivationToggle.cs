using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationToggle : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3; // custom stages behind portals
    public GameObject key;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            p1.SetActive(!p1.activeSelf);
            p2.SetActive(!p2.activeSelf);
            p3.SetActive(!p3.activeSelf);
            key.SetActive(true);
        }
    }
}
