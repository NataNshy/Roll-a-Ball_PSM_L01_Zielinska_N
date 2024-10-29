using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;



public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(20 * Time.deltaTime, 0, 0);


    }

    void OnTriggerEnter(Collider collision)
    {

        collision.gameObject.GetComponent<MovementController>().CollectScore();
        gameObject.SetActive(false);

    }
}

    
