using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCubeController : MonoBehaviour
{
    public float speed;
    public int direction;

    private void Start()
    {
        speed = 1f;
        //direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * direction * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.collider.CompareTag("Player"))
        {
            direction *= -1;
        }
        
        //Debug.Log("COLLISION ENTERED");
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            direction *= -1;
        }
    }*/
}
