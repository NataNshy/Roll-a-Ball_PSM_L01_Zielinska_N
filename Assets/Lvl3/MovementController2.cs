using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovementController2 : MonoBehaviour
{
    public Text scoreText; //score
    public int score = 0;

    Rigidbody kula;
    public float thrust = 5;
    public float bthrust = -5;

    // Nowe zmienne
    public GameObject spherePrefab;
    public List<GameObject> tailSpheres = new List<GameObject>(); // Lista od ogonka
    public float followDistance = 1.5f;
    public float followSpeed = 5f;


    void Start()
    {
        kula = GetComponent<Rigidbody>();
        Debug.Log("Dzieñ dobry!");
    }

    private void Update()
    {
        // Menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        // Testowe dodawanie kuli
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AddTailSphere();
        }


        UpdateTailPositions();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            kula.AddForce(0, 0, thrust);
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

    //zbieranie "jedzenia"
    private void OnTriggerEnter(Collider other)
    {
        /* po 3h walki to dalej nie dziala nie wazne co sie nie ustawi if (other.gameObject.CompareTag("TailSphere"))
        {
            // Rip
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } */

        if (other.gameObject.CompareTag("Item"))
        {
            AddTailSphere();
            score++;
            if (scoreText != null)
            {
                scoreText.text = $"Punkty: {score}";
            }
            Destroy(other.gameObject);

            if (score >= 15)
            {
                Debug.Log("Koniec  Suma punktów: " + score);
                scoreText.text = "Koniec";
                StartCoroutine(WaitAndLoadNextScene());
            }
        }

        if (other.gameObject.CompareTag("Reset"))
        {
            Debug.Log("Resetowanie poziomu...");
            ResetLevel();
        }
    }

    void AddTailSphere()
    {

        GameObject newSphere = Instantiate(spherePrefab);



        Vector3 spawnPosition;


        if (tailSpheres.Count > 0)
        {
            spawnPosition = tailSpheres[tailSpheres.Count - 1].transform.position; // pozycja ostatniej kuli
            spawnPosition.z -= 2f;
        }
        else
        {

            spawnPosition = transform.position;
            spawnPosition.z -= 2f;
        }


        newSphere.transform.position = spawnPosition;
        newSphere.tag = "TailSphere";
        tailSpheres.Add(newSphere);





        Debug.Log("Pozycja gracza: " + transform.position);
        Debug.Log("Pozycja nowej kuli: " + spawnPosition);



    }


    void UpdateTailPositions()
    {
        Vector3 previousPosition = transform.position; // Pozycja "g³owy"
        for (int i = 0; i < tailSpheres.Count; i++)
        {
            GameObject sphere = tailSpheres[i];
            Vector3 targetPosition = previousPosition - (previousPosition - sphere.transform.position).normalized * followDistance;
            sphere.transform.position = Vector3.Lerp(sphere.transform.position, targetPosition, followSpeed * Time.deltaTime);
            previousPosition = sphere.transform.position;
        }
    }

    void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator WaitAndLoadNextScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // next scena
    }
}

