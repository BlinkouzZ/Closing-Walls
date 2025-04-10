using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Quest Related")]
    public int questID = 0; //this identifies what quest is currently active

    [Header("UI Related")]
    public TextMeshProUGUI TextMonologue;
    public TextMeshProUGUI TextQuest;

    void Start()
    {

    }

    void Update()
    {
        switch (questID)
        {
            case 0:
                TextQuest.text = "Who's that?";
                break;
            case 1:
                TextQuest.text = "I guess I'll do that.";
                break;
            default:
                TextQuest.text = "";
                break;
        }
    }
}

