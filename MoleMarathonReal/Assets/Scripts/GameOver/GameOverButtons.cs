using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    Button[] popUpMenu = new Button[4];
    // Start is called before the first frame update
    void Start()
    {
        popUpMenu[0] = GameObject.Find("Repeat").GetComponent<Button>();
        popUpMenu[0].onClick.AddListener(tryAgain);

        popUpMenu[1] = GameObject.Find("Levels").GetComponent<Button>();
        popUpMenu[1].onClick.AddListener(LevelSelect);

        popUpMenu[2] = GameObject.Find("Menu").GetComponent<Button>();
        popUpMenu[2].onClick.AddListener(Menu);

        popUpMenu[3] = GameObject.Find("Quit").GetComponent<Button>();
        popUpMenu[3].onClick.AddListener(Quit);

    }

    // Update is called once per frame
    void tryAgain()
   {
        SceneManager.LoadScene("Level 1");
   }

    void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    void Quit()
    {
        Application.Quit();
    }
}
