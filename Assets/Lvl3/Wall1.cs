using UnityEngine;

public class Wall2 : MonoBehaviour
{
    public float speed = 3f; 
    public Vector3 direction = Vector3.right; 

    private void Update()
    {
        
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

