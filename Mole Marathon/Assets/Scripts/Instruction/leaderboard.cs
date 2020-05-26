using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leaderboard : MonoBehaviour
{

    private Button click;
    private Text text;

    private void Start()
    {
        //back = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
        click = GameObject.Find("LeaderBoard").GetComponent<Button>();
        text = GameObject.Find("text").GetComponent<Text>();
        click.onClick.AddListener(mouse);
    }
    private void mouse()
    {
        text.text = "The leaderboard represents all players that have attempted at playing the game and shows information such as times taken" +
            " to complete each level and how much tokens the player profile currently posess.";
    }
}
