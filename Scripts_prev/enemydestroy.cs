using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//nickyougotthisbuddy
public class enemydestroy : MonoBehaviour
{
   public int life = 0;

    //public void OnCollisionEnter(Collision boom)
    // {
    //If the object that triggered this collision is tagged "bullet"
    // if (gameObject.tag == "bullet")
    //  {
    //     life += 1;
    //    print("hit");
    //   if (life >= 3)
    // gameObject.GetComponent<Animator>().enabled = false;
    //     Destroy(gameObject);
    // }
    //}
    //}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "bullet")
        {
            life += 1;
               print("hit");
            if (life >= 3)
                // Destroy(gameObject);
                  gameObject.SetActive(false);
                //SetKinematic(false);
            //GetComponent<Animator>().enabled = false;
        }
    }
}
