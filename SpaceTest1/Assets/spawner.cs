using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] planes;
    public Transform[] points;
    public float beat = (60/130)*2;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            GameObject plane = Instantiate(planes[Random.Range(0, 2)], points[Random.Range(0, 6)]);
            plane.transform.localPosition = Vector3.zero;
            //plane.transform.Rotate(transform.forward,90 * Random.Range(0,4));
            timer -= beat;

        }
        timer += Time.deltaTime;
    }
}
