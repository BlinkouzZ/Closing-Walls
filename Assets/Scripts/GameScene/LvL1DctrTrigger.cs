using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LvL1DctrTrigger : MonoBehaviour
{
    public GameManager gameManager;

    [Header("Others")]
    public GameObject interactionBlockerObject;

    public void OnTriggerEnter(Collider other)
    {
        if (gameManager.questID < 2)
        {
            gameManager.questID = 1;
            gameManager.changeQuestID();
        }
        if (other.gameObject.CompareTag("Player") && gameManager.questID == 1)
        {
            gameManager.TextMonologue.gameObject.SetActive(true);
            gameManager.TextMonologue.text = "Press [F] to interact";
            Debug.Log("Can Interact");
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameManager.questID == 1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                gameManager.questID = 2;
                gameManager.changeQuestID();
                interactionBlockerObject.SetActive(false);
                gameManager.TextMonologue.text = "";
                gameManager.TextMonologue.gameObject.SetActive(false);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.TextMonologue.text = "";
            gameManager.TextMonologue.gameObject.SetActive(false);
        }
    }
}
