using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToGameButton : MonoBehaviour
{
    Button backButton;// Start is called before the first frame update
    void Start()
    {
        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        backButton.onClick.AddListener(back);
    }

    // Update is called once per frame
    void back()
    {
        SceneManager.LoadScene("Level 1");
    }
}
