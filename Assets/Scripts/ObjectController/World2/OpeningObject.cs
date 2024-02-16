using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OpeningObject : MonoBehaviour
{
    [Tooltip("All objects which should be opend / unlocked by this")]
    public List<OpenableObject> openableObjects;

    [Tooltip("All objects which should be opend / unlocked by this when not activated")]
    public List<OpenableObject> falseOpenableObjects;

    [Tooltip("wether this opens objects in list")]
    public bool opens = false;
    [Tooltip("wether this locks objects in list")]
    public bool locks = false;


    protected void Start()
    {
        toggle();

        //to reset the conditions in the false openable objects
        if (locks)
        {
            foreach (OpenableObject o in falseOpenableObjects)
            {
                o.toggleUnlockCondition(GetInstanceID());
            }
        }
        if (opens)
        {
            foreach (OpenableObject o in falseOpenableObjects)
            {
                o.toggleOpenCondition(GetInstanceID());
            }
        }
    }

    public void toggle()
    {
        //to set the conditions in the openable objects
        if (locks)
        {
            foreach (OpenableObject o in openableObjects)
            {
                o.toggleUnlockCondition(GetInstanceID());
            }
            foreach (OpenableObject o in falseOpenableObjects)
            {
                o.toggleUnlockCondition(GetInstanceID());
            }
        }
        if (opens)
        {
            foreach (OpenableObject o in openableObjects)
            {
                o.toggleOpenCondition(GetInstanceID());
            }
            foreach (OpenableObject o in falseOpenableObjects)
            {
                o.toggleOpenCondition(GetInstanceID());
            }
        }
    }


    protected abstract void OnCollisionEnter(Collision collision);
}
