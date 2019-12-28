using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    public void MainScreen()
    {
        SceneManager.LoadScene("Choice Screen");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
