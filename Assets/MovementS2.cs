using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Movement scianki
public class MovementS2 : MonoBehaviour
{
    public float speed = 2;
    public float minZ = -3;
    public float maxZ = 3;
    public bool up = false;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        Vector3 v = transform.position;
        float sz = speed * Time.deltaTime;
        if (up)
        {
            v.z = v.z - sz;
            if (v.z <= minZ)
            {
                v.z = minZ;
                up = false;
            }
        }
        else
        {
            v.z = v.z + sz;
            if (v.z >= maxZ)
            {
                v.z = maxZ;
                up = true;
            }
        }
        transform.position = v;
    }
}
