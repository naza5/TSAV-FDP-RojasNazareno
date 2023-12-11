using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void quitApp()
    {
        Application.Quit();
    }
    public void goToEscena1()
    {
        SceneManager.LoadScene(1);
    }
    public void goToEscena2()
    {
        SceneManager.LoadScene(2);
    }

    public bool pauseOn;
    public void play()
    {
        pauseOn = !pauseOn;
        Time.timeScale = 1;
    }
}