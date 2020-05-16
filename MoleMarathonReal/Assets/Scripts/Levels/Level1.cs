using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    private Button click;

    private void Start()
    {
        click = GameObject.Find("Level 1").GetComponent<Button>();
        click.onClick.AddListener(mouse);
    }

    private void mouse()
    {
        SceneManager.LoadScene("Level 1");
    }
}
