using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseMenu : MonoBehaviour
{
    
    public GameObject pausePanel;

    public void onPauseMenu()
    {

        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void onGameResume()
    {

        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void onGameQuit()
    {

        SceneManager.LoadScene(1);
    }

    public void backToMainMenu()
    {

        SceneManager.LoadScene(0);
    }
}
