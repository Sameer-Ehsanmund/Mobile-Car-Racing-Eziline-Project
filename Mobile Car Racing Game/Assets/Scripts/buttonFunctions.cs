using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{

    public void selectTrack()
    {

        SceneManager.LoadScene(11);
    }

    public void track1Selection()
    {

        SceneManager.LoadScene(1);
    }

    public void track2Selection()
    {

        SceneManager.LoadScene(2);
    }

    public void track3Selection()
    {

        SceneManager.LoadScene(3);
    }

    public void track4Selection()
    {

        SceneManager.LoadScene(4);
    }

    public void track5Selection()
    {

        SceneManager.LoadScene(5);
    }

    public void track6Selection()
    {

        SceneManager.LoadScene(6);
    }

    public void track7Selection()
    {

        SceneManager.LoadScene(7);
    }

    public void track8Selection()
    {

        SceneManager.LoadScene(8);
    }

    public void track9Selection()
    {

        SceneManager.LoadScene(9);
    }

    public void track10Selection()
    {

        SceneManager.LoadScene(10);
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

        SceneManager.LoadScene(12);
    }
}