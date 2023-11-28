using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine; 

public class startbut : MonoBehaviour
{
   
    public void SceneAR()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    public void SceneMenu()
    {
        SceneManager.LoadScene(0);
    }
}
