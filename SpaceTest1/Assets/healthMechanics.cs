using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthMechanics : MonoBehaviour
{
    public Image Bar;
    public float fill;
    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }

    // Update is called once per frame
    /*void Update()
    {
        fill -= Global.HealthCount * 0.01f;
        Bar.fillAmount = fill;
    }*/

    public void ReduceOnHit()
    {
        if(Global.HealthCount == 6.0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            fill -= Global.HealthCount * 0.05f;
            Bar.fillAmount = fill;
        }
        
    }
}
