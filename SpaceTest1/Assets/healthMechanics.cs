using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    void Update()
    {
        fill -= Global.HealthCount * 0.01f;
        Bar.fillAmount = fill;
    }

    /*public void ReduceOnHit()
    {
        fill -= Global.HealthCount * 0.01f;
        Bar.fillAmount = fill;
    }*/
}
