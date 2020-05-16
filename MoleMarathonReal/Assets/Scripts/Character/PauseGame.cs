using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool pauseIsOn = false;
    private Rigidbody[] pauseEffect = new Rigidbody[3];

    private void Start()
    {
        pauseEffect[0] = GameObject.Find("character").GetComponent<Rigidbody>();
        pauseEffect[1] = GameObject.Find("Fox").GetComponent<Rigidbody>();
        pauseEffect[2] = GameObject.Find("Falcon").GetComponent<Rigidbody>();
    }
    void Update()
    {
        pauseFunction();
    }

    private void pauseFunction()
    {
        if (Input.GetKeyDown(KeyCode.P) && pauseIsOn == false)
        {
            pauseIsOn = true;

            for(int x = 0; x < 3; x++)
            {
                pauseEffect[x].drag = 2000000;
            }
        }
        else if (Input.GetKeyDown(KeyCode.P) && pauseIsOn == true)
        {
            pauseIsOn = false;

            for (int x = 0; x < 3; x++)
            {
                pauseEffect[x].drag = 1;
            }
        }
    }
}
