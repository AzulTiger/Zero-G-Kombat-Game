using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_moveFighter : MonoBehaviour
{

    public GameObject Player;
    public float movementSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
       // transform.rotation = new Quaternion(rotx, roty, rotz, rotw);
        //transform.Rotate(transform.forward,90 * Random.Range(0,4));
        transform.position += transform.forward * movementSpeed * Time.deltaTime;


    }
}