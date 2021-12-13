using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class detecthit1 : MonoBehaviour {
    // public SimpleHealthBar healthBar;
    public Slider healthbar;
   Animator anim;


    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hit");
        //healthBar.UpdateBar(90,100);//100-90 is 10 damage//90,100//
        //if (healthBar.UpdateBar(90,100)) ;
        healthbar.value -= 5;
        if(healthbar.value <=0)
        anim.SetBool("girldie", true);
      // healthbar.value -= 20;

       
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {

    }
}

