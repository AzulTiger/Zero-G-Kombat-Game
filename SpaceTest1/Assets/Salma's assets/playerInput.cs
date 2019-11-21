using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    // Start is called before the first frame update
    public laser[] laserRight;
    public laser[] laserLeft;
    public OVRInput.Button shootingButtonr;
    public OVRInput.Button shootingButtonl;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyDown(KeyCode.L)
        //OVRInput.GetDown(shootingButton)
        if (OVRInput.GetDown(shootingButtonr)) 
        {
            //Debug.Log("Press worked");
            foreach (laser r in laserRight)
            {
                //Vector3 pos = transform.forward * l.Distance;
                
                r.FireLaser();
                
            }
           
        }
        //Input.GetKeyDown(KeyCode.J)
        if (OVRInput.GetDown(shootingButtonl))
        {
            //Debug.Log("Press worked");
            foreach (laser l in laserLeft)
            {
                //Vector3 pos = transform.forward * l.Distance;

                l.FireLaser();

            }

        }

    }
}
