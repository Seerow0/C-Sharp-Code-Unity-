﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnfracturedobject : MonoBehaviour
{
    public GameObject originalObject;
    public GameObject fracturedObject;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnFracturedObject();
        }
    }
    public void SpawnFracturedObject()
    {
        Destroy(originalObject);
        GameObject fractObj = Instantiate(fracturedObject) as GameObject;
        fractObj.GetComponent<explode>().Explode();


    }

}
