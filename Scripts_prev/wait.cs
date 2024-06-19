using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait : MonoBehaviour
{
    public bool Hide = false;


    void Update()
    {
        if (Hide
            && GetComponent<Renderer>().enabled)
        {
            GetComponent<Renderer>().enabled = false;
            Hide = false;
            StartCoroutine("WaitUnhide");
        }
    }


    IEnumerator WaitUnhide()
    {
        yield return (new WaitForSeconds(30));
        GetComponent<Renderer>().enabled = true;
    }
}
