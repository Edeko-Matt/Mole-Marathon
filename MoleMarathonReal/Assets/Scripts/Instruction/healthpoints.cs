using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthpoints : MonoBehaviour
{
    private Button click;
    private Text text;

    private void Start()
    {
        //back = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
        click = GameObject.Find("healthPoints").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }
    private void mouse()
    {
        text.text = "Healthpoints are the games representation of a players health to indicate that the player still have lives to continue " +
            " playing the game. The healtpoints can be deducted if attacked by enemies and restored when using bugs that are found underground.\n\n";
    }
}
