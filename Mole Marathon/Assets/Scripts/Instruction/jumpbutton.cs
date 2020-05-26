using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpbutton : MonoBehaviour
{
    private Button click;
    private Text text;

    private void Start()
    {
        //back = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
        click = GameObject.Find("jumpbutton").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }

    private void mouse()
    {
        text.text = "The jump function are activated in the game using the up arrow key to make the player jump and are used to avoid obstacles" +
            " and any potential enemies that the player make encounter along the way. The jump height of the character can be increased by the" +
            " upgrades in the upgrade market using tokens in the game.";
    }
}
