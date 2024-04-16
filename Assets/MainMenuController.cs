using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    public CanvasGroup OptionPanel;

    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OptionsRules()
    {
        SceneManager.LoadScene(1);
    }

    public void Option()
    {
        OptionPanel.alpha = 1;
        OptionPanel.blocksRaycasts = true;
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
        OptionPanel.alpha = 0;
        OptionPanel.blocksRaycasts = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
