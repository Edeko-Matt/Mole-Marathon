using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BugButtons : MonoBehaviour
{
    Button[] bugButton = new Button[4]; //array of yellow, green, red and blue buttons
    FoxScript foxScript;
    
    void Start()
    {
       
        bugButton[0] = GameObject.Find("yellow").GetComponent<Button>();
        bugButton[0].onClick.AddListener(yellowDecrease);

        bugButton[1] = GameObject.Find("blue").GetComponent<Button>();
        bugButton[1].onClick.AddListener(blueDecrease);

        bugButton[2] = GameObject.Find("green").GetComponent<Button>();
        bugButton[2].onClick.AddListener(greenDecrease);

        bugButton[3] = GameObject.Find("red").GetComponent<Button>();
        bugButton[3].onClick.AddListener(redDecrease);

        foxScript = FindObjectOfType<FoxScript>();

    }

    void yellowDecrease() //yellow bug increases the health points by 2
    {
        if (FoxScript.health == 1 || FoxScript.health == 2 || FoxScript.health == 3) //1+3-1 =case 3; 2+3-1= case 4; 3+3-1=case 5
        {
            FoxScript.health += 3;
            foxScript.healthSystem();
            Inventory.yellowBugs-=1;
        }
        else if (FoxScript.health == 4)
        {
            FoxScript.health += 2;
            foxScript.healthSystem();
            Inventory.yellowBugs -= 1;
        }
    
    }
    void blueDecrease() // blue bug restores all the healthPoints
    {
        if(Inventory.blueBugs > 0)
        {
            FoxScript.health = 6; 
            foxScript.healthSystem(); //case 5 for all
            Inventory.blueBugs -= 1;


        }
    }
    void greenDecrease() // restores 1 healthpoint
    {
        if(Inventory.greenBugs > 0)
        {
            FoxScript.health += 2;
            foxScript.healthSystem(); //case 5 for all
            Inventory.greenBugs -= 1;
        }
            
    }
    void redDecrease() //restores 3
    {
        if(Inventory.redBugs > 0)
        {
            Inventory.redBugs--;
            if(FoxScript.health == 1 || FoxScript.health == 2)  // 1+4-1 = 4 (case 4 gives 4 heart symbols), 2+4-1 = 5(case 5)
            {
                FoxScript.health += 4;  //restores 3 health points. The reason why it is += 4 is because healthSystem() will decrease health by 1
                foxScript.healthSystem();
            }
            else if(FoxScript.health == 3)
            {
                FoxScript.health += 3;
                foxScript.healthSystem();
            }
            else if (FoxScript.health == 4)
            {
                FoxScript.health += 2;
                foxScript.healthSystem();
            }

        }
        
      
    }

}
