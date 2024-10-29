using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartG()
    {
        Debug.Log("Scene loading: " + scenePaths[1]);
        SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
    }

    public void Options()
    {

    }

    public void ExitG()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
