using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
//Score, dzwiek


public class Collectible : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip pickupSound;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(20 * Time.deltaTime, 0, 0);


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Punkt podniesiony!");
            collision.gameObject.GetComponent<MovementController>().CollectScore();
            if (audioSource != null && pickupSound != null)
            {
                audioSource.PlayOneShot(pickupSound);
            }

            // wy³¹czenie renderowania obiektu?
            if (meshRenderer != null)
            {
                meshRenderer.enabled = false;
            }

            // 
            float delay = pickupSound != null ? pickupSound.length : 2f; // Czas trwania dŸwiêku
            Invoke(nameof(DisableObject), delay);
        }
    }
        private void DisableObject()
        {
            gameObject.SetActive(false);
        }

    
}

    
