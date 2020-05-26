using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstructionButton : MonoBehaviour
{
    private Button click;

    private void Start()
    {
        click = GameObject.Find("Instruction Button").GetComponent<Button>();
        click.onClick.AddListener(mouse);
    }

    private void mouse()
    {
        SceneManager.LoadScene("Instructions");
    }
}
