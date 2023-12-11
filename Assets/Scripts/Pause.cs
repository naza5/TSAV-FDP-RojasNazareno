using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PanelPausa;
    public bool pauseOn;
    public void play()
    {
        pauseOn = !pauseOn;
        Time.timeScale = 1;
    }
    public void changeScene()
    {
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseOn = !pauseOn;
            PanelPausa.SetActive(pauseOn);

            if (!pauseOn)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
}



