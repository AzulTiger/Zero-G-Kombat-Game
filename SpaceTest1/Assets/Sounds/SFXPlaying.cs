using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{

    public AudioSource GunShot;
    public AudioSource LaserShot;
    public AudioSource ExplosionSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void PlayGunShot()
    {
        GunShot.Play();

    }

    public void PlayLaserShot()
    {
        LaserShot.Play();

    }

    public void PlayExplosionSound()
    {
        ExplosionSound.Play();

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayLaserShot();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlayGunShot();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayExplosionSound();
        }
    }
}
