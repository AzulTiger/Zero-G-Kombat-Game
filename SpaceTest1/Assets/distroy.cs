using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distroy : MonoBehaviour
{
    public GameObject explosionps;
    public AudioSource ExplosionSound;

    public LayerMask layer;
    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void PlayExplosionSound()
    {
        ExplosionSound.Play();

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            //if(Vector3.Angle(transform.position-previousPos,hit.transform.up)>130)
            // {
            // hit.transform.GetComponent<explosionScript>().GotHit(hit.point);
            Global.scoreCount = Global.scoreCount + 1;
            GameObject go = Instantiate(explosionps, hit.point, Quaternion.identity);
            //Destroy(hit.transform.gameObject);
            Destroy(hit.transform.gameObject);
            PlayExplosionSound();


            // }

        }
        previousPos = transform.position;
    }
}
