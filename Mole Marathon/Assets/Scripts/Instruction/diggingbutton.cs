using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diggingbutton : MonoBehaviour
{
    private Button click;
    private Text text;

    private void Start()
    {
        //back = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
        click = GameObject.Find("diggingbutton").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }

    private void mouse()
    {
        text.text = "Digging in this game are achieved using the down arrow key function to make the character dive underground and then using " +
            "the left and right arrow keys to make the character move left and right underground\n\n-down Arrow = go undergound";
    }
}
