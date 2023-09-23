using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject pausemenu;
    public GameObject finishmenu;
    //public GameObject losemenu;
    public bool ispaused;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(ispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pausemenu.SetActive(true);
        ispaused = true;
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pausemenu.SetActive(false);
        ispaused = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Gameomplete()
    {
        Time.timeScale = 0;
        finishmenu.SetActive(true);
    }
    /*public void GameOver()
    {
        Time.timeScale = 0;
        losemenu.SetActive(true);
    }*/
}
