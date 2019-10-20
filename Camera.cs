using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera : MonoBehaviour
{
    GameObject rocket;
    Vector3 vec;

    void Start()
    {
        rocket = GameObject.FindGameObjectWithTag("rocket");
        vec = transform.position - rocket.transform.position;
       

    }


    // Update is called once per frame
    void Update()

    {
        transform.position = rocket.transform.position + vec;
    }

    


    }

