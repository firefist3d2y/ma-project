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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            player.transform.position = otherPortal.transform.position + new Vector3(spawnX, spawnY, spawnZ);
        }
    }
}
