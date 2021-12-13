using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnPress1 : MonoBehaviour
{
    public AudioSource someSound;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            someSound.Play();
        }
    }
}
