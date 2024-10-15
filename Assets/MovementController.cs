using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int score;
    

    Rigidbody kula;
    public float thrust = 5;
    public float bthrust = -5;

    // Start is called before the first frame update
    void Start()
    {
        kula = GetComponent<Rigidbody>(); //biezrze to co ma dodany rigidbody
        Debug.Log("Dzien dobry!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            kula.AddForce(0, 0 ,thrust);
        }

        if (Input.GetKey(KeyCode.A))
        {

            kula.AddForce(bthrust, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {

            kula.AddForce(0, 0, bthrust);
        }

        if (Input.GetKey(KeyCode.D))
        {

            kula.AddForce(thrust, 0, 0);
        }
    }
}
