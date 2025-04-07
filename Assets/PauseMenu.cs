using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {

        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }

    }

    public void Resume()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }

}
