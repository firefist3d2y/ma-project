using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.UIElements;

public class KeyScript : MonoBehaviour
{
    private Boolean isCollected;
    private GameObject player;
    private Vector3 offset;

    private void Start()
    {
        isCollected = false;
        offset = new Vector3(2f, 2f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            isCollected = true;
            player = other.gameObject;
        }
    }

    private void Update()
    {
        if (isCollected)
        {
            //transform.Translate(player.transform.position.x + 5, player.transform.position.y + 5, player.transform.position.z + 5);
            transform.position = player.transform.position + offset;
        }
    }

    public Boolean getIsCollected()
    {
        return isCollected;
    }
}
