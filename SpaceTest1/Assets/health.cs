﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosionps;
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.name == "spaceship1 (1)") || (collision.gameObject.name == "spaceship2 (1)"))
        {

            Vector3 point = collision.contacts[0].point;

            GameObject go = Instantiate(explosionps, point, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }

}
