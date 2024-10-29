using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    public Text sText; //score
    public Text Text1;
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
    public void CollectScore()
    {
        score += 1;
        Debug.Log("+1 punkt!");
        sText.text = "Score: " + score;
        if (score >= 4)
        {
            Debug.Log("Koniec :3 Suma punktów: " + score);
            Text1.text = "Koniec :3";
        }
    }
}
