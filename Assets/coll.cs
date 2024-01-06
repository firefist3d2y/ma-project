using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class coll : MonoBehaviour
{
    private float movementSpeed;
    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 5f;
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * movementSpeed * direction);
    }

    void onColiisionEnter(Collider col)
    {
        direction *= -1;
    }
}
