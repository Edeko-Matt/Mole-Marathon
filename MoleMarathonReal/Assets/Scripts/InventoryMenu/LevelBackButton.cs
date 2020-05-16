using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelBackButton : MonoBehaviour
{
    private Button click;

    private void Start()
    {
       
        click = GameObject.Find("Back Button").GetComponent<Button>();
        click.onClick.AddListener(mouse);
    }

    private void mouse()
    {
        SceneManager.LoadScene("Menu");
    }
}
