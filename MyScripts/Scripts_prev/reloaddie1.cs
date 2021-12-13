using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloaddie1 : MonoBehaviour
{




    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "final")
        {
            SceneManager.LoadScene("FinalScene");
            //Or:
            //SceneManager.LoadScene (SceneIndex); //(without these: ", because it's a number - an int, not a string)
        }
    }
}
