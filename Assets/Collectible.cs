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
    

    void OnTriggerEnter(Collider collision) //natala ty debilu nie do update'a
    {
        //if (collider.gameObject.name == "kula")
       
    collision.gameObject.GetComponent<MovementController>().score += 1;
        

        Debug.Log("+1 punkt!");

        gameObject.SetActive(false);


        if (collision.gameObject.GetComponent<MovementController>().score >= 4)
        {
            Debug.Log("Koniec :3 Suma punktów: " + collision.gameObject.GetComponent<MovementController>().score);
        }


    }

}
