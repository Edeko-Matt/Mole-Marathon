using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    Button[] pauseButtons = new Button[4];
    // Start is called before the first frame update
    void Start()
    {
        pauseButtons[0] = GameObject.Find("Restart").GetComponent<Button>();
        pauseButtons[0].onClick.AddListener(reload);

        pauseButtons[1] = GameObject.Find("menu").GetComponent<Button>();
        pauseButtons[1].onClick.AddListener(Menu);

        pauseButtons[2] = GameObject.Find("Quit").GetComponent<Button>();
        pauseButtons[2].onClick.AddListener(Quit);

        pauseButtons[3] = GameObject.Find("UpgradeStore").GetComponent<Button>();
        pauseButtons[3].onClick.AddListener(UpgradeStore);


    }

    // Update is called once per frame
    void reload()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name); //will reload current scene
    }

    
    void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    void Quit()
    {
        Application.Quit();
    }

    void UpgradeStore()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("UpgradeStore");
        print("The button is pressed");
    }
}
