using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySelect : MonoBehaviour
{
    public GameObject DifficultyToggles;

    private void Start()
    {
        DifficultyToggles.transform.GetChild((int)DifficultyValues.Difficulty).GetComponent<Toggle>().isOn = true;
    }

    #region
    public void SetEasyDifficulty(bool isOn)
    {
        if (isOn)
            DifficultyValues.Difficulty = DifficultyValues.Difficulties.Easy;
        Debug.Log("e");
    }
    public void SetMediumDifficulty(bool isOn)
    {
        if (isOn)
            DifficultyValues.Difficulty = DifficultyValues.Difficulties.Medium;
        Debug.Log("m");
    }
    public void SetHardDifficulty(bool isOn)
    {
        if (isOn)
            DifficultyValues.Difficulty = DifficultyValues.Difficulties.Hard;
        Debug.Log("h");
    }

    #endregion
}
