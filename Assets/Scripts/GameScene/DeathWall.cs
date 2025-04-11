using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Trigger_DeathWall : MonoBehaviour
{

    public string levelToLoad; //referenced to the specific scene to load

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene(levelToLoad); //load specified scene
        }
    }
    void Update()
    {
        transform.Translate(0, -0.5f * Time.deltaTime, 0);
    }
}