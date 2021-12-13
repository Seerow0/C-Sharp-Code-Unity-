using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloaddie : MonoBehaviour
{




    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "spikes")
        {
            SceneManager.LoadScene("Official2");
            //Or:
            //SceneManager.LoadScene (SceneIndex); //(without these: ", because it's a number - an int, not a string)
        }
    }
}
