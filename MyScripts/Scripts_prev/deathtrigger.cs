

  using UnityEngine;
using System.Collections;

public class deathtrigger : MonoBehaviour


{

    public bool death;
    private GameObject player;
    private Animator anim;
    private AudioClip sound;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        anim.SetBool("death", true);
        GetComponent<AudioSource>().Play();
    }

    void OnTriggerExit(Collider other)
    {
        anim.SetBool("death", false);
    }
}