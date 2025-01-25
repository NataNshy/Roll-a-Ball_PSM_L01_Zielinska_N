using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed = 5f; 
    public Vector3 direction = Vector3.forward; // lub Vector3.right )

    private void Update()
    {
        
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

