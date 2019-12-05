using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosionps;
    private  int hitCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GotHit(Vector3 pos)
    {
        //GameObject go = Instantiate(explosion, pos, Quaternion.identity, transform) as GameObject;
       // GameObject go = Instantiate(explosionps,hit.point,)
       // Destroy(go, 6f);

        hitCount++;
        //return hitCount;

    }
}
