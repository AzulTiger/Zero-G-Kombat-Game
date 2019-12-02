using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTrigger : MonoBehaviour
{
    private SimpleShoot simpleShoot;
    public OVRInput.Button shootingButton;
    // Start is called before the first frame update
    void Start()
    {
        // Access the simple shoot script
        simpleShoot = GetComponent<SimpleShoot>();

    }

    // Update is called once per frame
    void Update()
    {
        // Player shoots if button on controller is triggered
        if (OVRInput.GetDown(shootingButton))
        {
            //Shoot !!!
            simpleShoot.TriggerShoot();
        }
        
    }
}
