using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Quest Related")]
    public int questID = 0; //this identifies what quest is currently active

    [Header("UI Related")]
    public Text TextMonologue;
    public Text TextQuest;

    void Start()
    {

    }

    void Update()
    {
        switch (questID)
        {
            case 0:
                TextQuest.text = "Embark on your new journey!";
                break;
            case 1:
                TextQuest.text = "Oops! Get your backpack from your house.";
                break;
            case 2:
                TextQuest.text = "Alright! Greet and talk to your master at his house.";
                break;
            case 3:
                TextQuest.text = "Oh? Find the items he asked for.";
                break;
            case 4:
                TextQuest.text = "Find the next item. ";
                break;
            case 5:
                TextQuest.text = "Return to Master.";
                break;
            case 6:
                TextQuest.text = "Basic Tutorial Completed!";
                break;
            default:
                TextQuest.text = "";
                break;
        }
    }
}

