using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    // Start is called before the first frame update
    public laser[] laserRight;
    public laser[] laserLeft;
    //public OVRInput.Button shootingButton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyDown(KeyCode.L)
        //OVRInput.GetDown(shootingButton)
        if (Input.GetKeyDown(KeyCode.L)) 
        {
            //Debug.Log("Press worked");
            foreach (laser r in laserRight)
            {
                //Vector3 pos = transform.forward * l.Distance;
                
                r.FireLaser();
                
            }
           
        }
        if (Input.GetKeyDown(KeyCode.J))
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
