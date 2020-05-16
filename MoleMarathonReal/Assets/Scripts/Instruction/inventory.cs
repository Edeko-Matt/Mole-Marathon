using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    private Button click;
    private Text text;

    private void Start()
    {
         click = GameObject.Find("Inventory").GetComponent<Button>();
     
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }
    private void mouse()
    {
        text.text = "The inventory system represents items that have been picked up in the game including bugs and potential powerups to alter" +
            " and help the player in his quest to complete the game.";
    }
}
