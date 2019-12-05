using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        //x position, y position
        GUI.Box(new Rect(100, 300, 100, 100), "Health");
    }
}
