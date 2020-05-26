using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
     public static Canvas popUp;
    void Start()
    {
        popUp = gameObject.GetComponent<Canvas>();
        popUp.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
