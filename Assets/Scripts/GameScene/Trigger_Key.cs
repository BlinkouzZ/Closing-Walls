using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Key : MonoBehaviour
{

    public GameObject doorTrigger;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                doorTrigger.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }
}