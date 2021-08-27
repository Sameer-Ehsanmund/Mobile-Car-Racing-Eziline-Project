using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{

    public void onRandomGame()
    {

        SceneManager.LoadScene(3);
    }

    public void selectTrack()
    {

        SceneManager.LoadScene(1);
    }

    public void track1Selection()
    {

        SceneManager.LoadScene(2);
    }

    public void quitGame()
    {

        Application.Quit();
    }

    public void backToMainMenu()
    {

        SceneManager.LoadScene(0);
    }

    public void onCredits()
    {

        SceneManager.LoadScene(4);
    }
}