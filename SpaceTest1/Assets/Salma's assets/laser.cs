using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LineRenderer))]

public class Global
{
    public static int scoreCount = 0;
    public static float HealthCount = 0.0f;
}
public class laser : MonoBehaviour
{
    public GameObject explosionps;
    public LayerMask layer;
    public AudioSource ExplosionSound;


    // Start is called before the first frame update
    LineRenderer lr;
    public float laserOffTime = 5f;
    public float laserDistance = 300f;
    public float fireDelay = 2.0f;
    bool enableFire;
    public int hitToDie = 2;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();

    }

    void Start()
    {
        lr.enabled = false;
        enableFire = true;

    }

    public void PlayExplosionSound()
    {
        ExplosionSound.Play();

    }

    /* void Update()
     {
         FireLaser();
     }*/

    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * laserDistance, Color.yellow);
    }
    
    Vector3 CastRay()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward) * laserDistance;
        if(Physics.Raycast(transform.position, fwd, out hit,30,layer))
        {
            Debug.Log("We hit: " + hit.transform.name);
            Global.scoreCount = Global.scoreCount + 1;
            Debug.Log("Score: " + Global.scoreCount);
            //int hits_of_inst = hit.transform.GetComponent<enemy_moveFighter>().GotHit(hit.point);
            //int hits_of_int = hit.transform.GetComponent<explosionScript>().GotHit(hit.point);
            // hit.transform.GetComponent<explosionScript>().GotHit(hit.point);
            GameObject go = Instantiate(explosionps, hit.point, Quaternion.identity);
           // if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
                 Destroy(hit.transform.gameObject);
            //adding explosion sound
           // PlayExplosionSound();




            return hit.point;
        }
        Debug.Log("we missed...");
        return transform.position + (transform.forward * laserDistance);

    }
    public void FireLaser()
    {
        //Vector3 targetPosition = transform.position + transform.forward * laserDistance;

        if (enableFire)
        {
            //Debug.Log("here in laser fire");
            //Starting position (0) 
            lr.SetPosition(0, transform.position);
            // if player position is less than something
            lr.SetPosition(1, CastRay());
            lr.enabled = true;
            enableFire = false;
            Invoke("DisableLaser", laserOffTime);
            Invoke("EnableFire", fireDelay);
        }
        

        

    }

    void DisableLaser()
    {
        lr.enabled = false;
       

    }
    public float Distance
    {
        get { return laserDistance; }
    }
    void EnableFire()
    {
        enableFire = true;
    }
}
