using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseCanvas;

    void Update()
    {
        pauseCanvas.SetActive(false);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (Time.timeScale == 0)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }
}
