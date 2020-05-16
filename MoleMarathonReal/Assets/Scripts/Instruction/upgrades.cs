using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgrades : MonoBehaviour
{

    private Button click;
    private Text text;

    private void Start()
    {
        //back = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
        click = GameObject.Find("Upgrades").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }
    private void mouse()
    {
        text.text = "The upgrade menu are a ingame function that are activated using the I function key to open the shop and use tokens to " +
            " purchase additional powerups as well as unlock more levels potentially";
    }
}
