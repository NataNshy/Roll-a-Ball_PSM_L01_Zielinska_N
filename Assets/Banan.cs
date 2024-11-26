using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1 * Time.deltaTime, 1, 0);
    }
    void OnTriggerEnter(Collider collision)
    {

        collision.gameObject.GetComponent<MovementController>().CollectScoreBanan();
        gameObject.SetActive(false);

    }
}
