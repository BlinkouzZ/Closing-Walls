using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvL1DctrTrigger : MonoBehaviour
{
    public GameManager gameManager;

    [Header("UI")]
    public Text InteractMonologue;

    [Header("Others")]
    public GameObject interactionBlockerObject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameManager.questID == 1)
        {
            InteractMonologue.text = "Press [F] to interact";
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameManager.questID == 1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                gameManager.questID = 2;
                interactionBlockerObject.SetActive(false);
                InteractMonologue.text = "";
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InteractMonologue.text = "";
        }
    }
}
