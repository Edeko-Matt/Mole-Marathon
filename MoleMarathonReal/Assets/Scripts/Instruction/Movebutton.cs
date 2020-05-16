using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movebutton : MonoBehaviour
{
    private Button click;
    private Text text;

    private void Start()
    {
        //back = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
        click = GameObject.Find("Movebutton").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }

    private void mouse()
    {
        text.text = "Movement in the game are created using the left and right arrow keys to make the character move in either the left or right direction." +
            "\n\n-Left Arrow = left direction axis\n-Right Arrow = right direction axis";
    }
}
