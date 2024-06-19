using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadsceneoncollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            SceneManager.LoadSceneAsync("level2");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            //Or:
            //SceneManager.LoadScene (SceneIndex); //(without these: ", because it's a number - an int, not a string)
        }
       // {
           // DontDestroyOnLoad(this.gameObject);
        //}
    }
}