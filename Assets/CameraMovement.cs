using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    
    Vector3 vectorcam;
    
    // Start is called before the first frame update
    void Start()
    {
        
        vectorcam = player.transform.position - transform.position; 

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - vectorcam;
    }
}
