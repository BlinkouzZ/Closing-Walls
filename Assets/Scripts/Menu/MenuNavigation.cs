using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public void BtnStart()
    {
        SceneManager.LoadScene("SampleScene");//this will load the specified level
    }

    public void BtnQuit()
    {
        Application.Quit();//this quits the build project
    }
}
