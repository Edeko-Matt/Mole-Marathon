using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool popUpIsOn;
    public Canvas pause;

    private void Start()
    {
        pause = GameObject.FindGameObjectWithTag("pause").GetComponent<Canvas>();
        pause.planeDistance = 0;
        popUpIsOn = false;
    }
    private void Update()
    {
        pauseGame();
    }
    void pauseGame()
    {
        if (Input.GetKey(KeyCode.P) && pause == false)
        {
           
           pause.planeDistance = 10;
            popUpIsOn = true;
            Time.timeScale = 0f;
           
        }
        else if(Input.GetKey(KeyCode.P) && pause == true)
        {
            popUpIsOn = false;
            pause.planeDistance = 0;
            Time.timeScale = 1f; 
           
       }
   }
}
