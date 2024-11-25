using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMController : MonoBehaviour
{


    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayGameNoIntro()
    {
        SceneManager.LoadScene(3);
    }

    public void OptionsRules()
    {
        SceneManager.LoadScene(1);
    }


    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}