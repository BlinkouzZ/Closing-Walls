using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string loadLevel;

    public void BtnLoadScene()
    {
        SceneManager.LoadScene(loadLevel);
    }

    public void BtnQuitScene()
    {
        Application.Quit();
    }
}
