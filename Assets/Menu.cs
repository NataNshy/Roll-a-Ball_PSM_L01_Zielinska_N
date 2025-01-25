using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void lvl1()
    {
        //  Debug.Log("Scene loading: " + scenePaths[1]);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void lvl2()
    {
        
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    public void lvl3()
    {

        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    public void Next()
    {

        if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1)

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        else

            SceneManager.LoadScene(0);

    }

    public void ExitG()
    {
        Application.Quit();
    }
}

   

