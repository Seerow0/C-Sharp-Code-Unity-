using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(0, 10, 0 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
