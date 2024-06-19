using UnityEngine;
using System.Collections;

public class Respawner : MonoBehaviour
{
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ground")
        {
            this.transform.position = new Vector3(-3.607f, 19.831f, 110.799f);
        }
    }
}