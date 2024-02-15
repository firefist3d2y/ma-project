using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeverController : OpeningObject
{
    Animator anim;

    [Tooltip("Lever is pressed or not")]
    public bool isActivated;

    new
    protected void Start()
    {
        base.Start();
        //Animator / animation is original from package
        anim = GetComponent<Animator>();
    }

    override
    protected void OnCollisionEnter(Collision collision)
    {
        toggle();
        isActivated = !isActivated;
        anim.SetBool("LeverUp", isActivated);
    }
}
