using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_moveFighter : MonoBehaviour
{

    public GameObject Player;
    public float rotationalDamp = 0.5f;
    public float movementSpeed = 10f;
    public float rotationOffset = 2.0f;
    //public GameObject explosion;
    //private  int hitCount = 0;



    // Start is called before the first frame update

    void Start()
    {
        transform.LookAt(Player.transform);

    }


    // Update is called once per frame
    void Update()
    {
        Turn();
        Move();
        //Turn();

        //transform.position += transform.forward * movementSpeed * Time.deltaTime;

    }

    void Turn()
    {
        Vector3 playerPos = Player.transform.position;
        playerPos.z = playerPos.z * rotationOffset;
        //Vector3 pos = Player.transform.position- transform.position;
        Vector3 pos = playerPos - transform.position;
        Quaternion rotation = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationalDamp * Time.deltaTime);

    }
    void Move()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
    /*public int GotHit(Vector3 pos)
    {
        GameObject go = Instantiate(explosion, pos, Quaternion.identity, transform) as GameObject;
        Destroy(go, 6f);
        hitCount++;
        return hitCount;

    }*/
}