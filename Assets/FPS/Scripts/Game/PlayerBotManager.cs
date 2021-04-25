using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBotManager : MonoBehaviour
{
    public GameObject[] bots;
    public int currentBot = 0;

    //script that handles the switchting between bots

    public void switchBot(int newBot)
    {
        bots[currentBot].transform.GetChild(0).gameObject.SetActive(false); //deactivates the player object on the current bot

        bots[newBot].transform.GetChild(0).gameObject.SetActive(true); //activates the player object on the new bot
        bots[newBot].transform.GetChild(1).gameObject.SetActive(false); //deactivates the bot object on the new bot

        currentBot = newBot;  //set the currentBot int to the new botID
    }
}
