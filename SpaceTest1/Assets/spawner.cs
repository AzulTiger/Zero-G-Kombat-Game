using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] planes;
    //public Transform[] points;
    public GameObject player;
    //public Camera view;
    public float spawnDistance = 10f;
    public float beat = (60 / 130) * 2;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion playerRotation = player.transform.rotation;
        //Vector3 point = new Vector3();
        //point = view.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), spawnDistance));

        Vector3 playerPos = player.transform.position;
        Vector3 playerDirection = player.transform.forward;
        Quaternion playerRotation = player.transform.rotation;
        //float spawnDistance = 10;

        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        //Vector3 spawnPos = playerPos;
        spawnPos.x += Random.Range(-10f, 10f);
        spawnPos.y += Random.Range(-6f, 6f);




        if (timer > beat)
        {
             GameObject plane = Instantiate(planes[Random.Range(0, 2)], spawnPos, playerRotation);
           // GameObject plane = Instantiate(planes[Random.Range(0, 2)], points[Random.Range(0,4)]);
           // plane.transform.localPosition = Vector3.zero;
            //plane.transform.Rotate(transform.forward,90 * Random.Range(0,4));
            timer -= beat;

        }
        timer += Time.deltaTime;
    }
}
