using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static int[] Bugs = new int[4];
    public static int yellowBugs;
    public static int greenBugs;
    public static int redBugs;
    public static int blueBugs;
    private bool InventoryIsOn;
    private Canvas invent;
    private Text[] bug = new Text[4];

    private void Start()
    {
        invent = GameObject.Find("Inventory").GetComponent<Canvas>();
        string[] name = new string[4];
        name[0] = "ytext";
        name[1] = "rtext";
        name[2] = "btext";
        name[3] = "gtext";
        for (int x = 0; x < 4; x++)
        {
            bug[x] = GameObject.Find(name[x]).GetComponent<Text>();
            bug[x].text = "" + Bugs[x];
        }

        invent.planeDistance = 0;
        InventoryIsOn = false;
    }
    void Update()
    {
        Bugs[0] = yellowBugs;
        Bugs[1] = redBugs;
        Bugs[2] = blueBugs;
        Bugs[3] = greenBugs;

       // print("yellow " + yellowBugs + " green " + Bugs[1] + " blue " + Bugs[2] + " red " + Bugs[3]);
        displayBugs();
        inventoryFunction();
    }

    private void displayBugs()
    {
        string[] name = new string[4];
        name[0] = "ytext";
        name[1] = "rtext";
        name[2] = "btext";
        name[3] = "gtext";
        for (int x = 0; x < 4; x++)
        {
              bug[x].text = ""+ Bugs[x];
        }
    }

    private void inventoryFunction()
    {
        if (Input.GetKeyDown(KeyCode.I) && InventoryIsOn == false)
        {
            InventoryIsOn = true;
            invent.planeDistance = 0;

        }
        else if (Input.GetKeyDown(KeyCode.I) && InventoryIsOn == true)
        {
            InventoryIsOn = false;
            invent.planeDistance = 10;
        }
    }
}
