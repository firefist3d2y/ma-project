using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public GameObject player;
    public GameObject otherPortal;
    public float spawnX;
    public float spawnY;
    public float spawnZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Portal Collision detected!");
        if (collision.collider.CompareTag("Player"))
        {
            player.transform.position = otherPortal.transform.position + new Vector3(spawnX, spawnY, spawnZ);
        }
    }
}
