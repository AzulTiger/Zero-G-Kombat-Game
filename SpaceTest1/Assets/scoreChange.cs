using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreChange : MonoBehaviour
{
   private TextMesh text;
    //private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = (TextMesh)GameObject.Find("ScoreText").GetComponent<TextMesh>();
        //text.text = "pls";
    }

    void Awake()
    {
        //text = gameObject.AddComponent<TextMesh>();

        //text.text = Time.time.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        text.text = Global.scoreCount.ToString();
        //text.text = i.ToString();
        //i++;
    }
}
