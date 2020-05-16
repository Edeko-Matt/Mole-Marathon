using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tokens : MonoBehaviour
{

    private Button click;
    private Text text;

    private void Start()
    {
        //back = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
        click = GameObject.Find("Tokens").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }
    private void mouse()
    {
        text.text = "Tokens are floating coins found on the surface of the level that are collected when a character gets close to the coins" +
            " and are used as a ingame currency to be spend to receive permanent powerups during the game.";
    }
}
