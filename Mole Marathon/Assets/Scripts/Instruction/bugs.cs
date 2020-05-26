using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bugs : MonoBehaviour
{

    private Button click;
    private Text text;
    private void Start()
    {
        click = GameObject.Find("Bugs").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }
    private void mouse()
    {
        text.text = "Bugs are tiny creatures undergound of a level that move on its own and are picked up by the player and later consumed" +
            " to be used to restore a players healtpoints. Different colours of bugs indicate the different potency levels of each bug" +
            "\n\n-green bug = restore 1 healthpoint\n-yellow bug = restore 2 healthpoint\n-red bug = restore 3 healtpoints\n-blue bug = restore all healthpoints";
    }
}
