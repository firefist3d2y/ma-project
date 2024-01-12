using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public GameObject player;
    public GameObject otherPortal;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Portal Collision detected!");
        if (collision.collider.CompareTag("Player"))
        {
            player.transform.position = otherPortal.transform.position + new Vector3(1, 1, 0);
        }
    }
}
