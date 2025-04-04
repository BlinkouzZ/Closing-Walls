using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Door_Open : MonoBehaviour
{
    public GameObject Door;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F) && key1.gameObject.activeInHierarchy == false && key2.gameObject.activeInHierarchy == false && key3.gameObject.activeInHierarchy == false)
            {
                this.gameObject.SetActive(false);
                Door.gameObject.SetActive(false);
            }
        }
    }
}