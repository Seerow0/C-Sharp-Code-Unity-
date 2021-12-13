using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tst : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            anim.SetBool("death", true);
    }
}