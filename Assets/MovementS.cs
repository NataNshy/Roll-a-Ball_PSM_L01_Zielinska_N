using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Movement scianki
public class MovementS : MonoBehaviour
{
    public float speed = 2;
    public float minX = -3;
    public float maxX = 3;
    private bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
        Vector3 v = transform.position;
        float sx = speed * Time.deltaTime;
        if (left)
        {
            v.x = v.x - sx;
            if (v.x <= minX)
            {
                v.x = minX;
                left = false;
            }
        }
        else
        {
            v.x = v.x + sx;
            if (v.x >= maxX)
            {
                v.x = maxX;
                left = true;
            }
        }
        transform.position = v;
    }
}
