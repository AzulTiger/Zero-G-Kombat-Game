using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    //public int CurrentScore = 0;
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
        GUI.Box(new Rect(300, 300, 100, 100), "Score \n "+ Global.scoreCount);
        
    }
}
