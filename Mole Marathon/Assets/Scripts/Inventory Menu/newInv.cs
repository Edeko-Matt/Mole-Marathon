using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newInv : MonoBehaviour
{

    [SerializeField] Text yBugText;
    [SerializeField] Text gBugText;
    [SerializeField] Text bBugText;
    [SerializeField] Text rBugText;
    [SerializeField] Text healthText;
    [SerializeField] Text coinsText;
    [SerializeField] Text silverCoinText;
  
    int yBugCount;
    int bBugCount;
    int gBugCount;
    int rBugCount;
    int healthPoints;
    int goldenCoins;
    int silverCoins;
   
    GameObject[] heartObj = new GameObject[5];
    Image[] heartImages = new Image[5]; 

    string[] h = {"Heart1", "Heart2", "Heart3", "Heart4", "Heart5"};

    
    // Start is called before the first frame update
    void Start()
    {
        yBugCount = Inventory.yellowBugs; 
        yBugText.text = "yellow bugs " + yBugCount;

        bBugCount = Inventory.blueBugs; 
        bBugText.text = "blue bugs " + bBugCount;

        gBugCount = Inventory.greenBugs; 
        gBugText.text = "green bugs " + gBugCount;

        rBugCount = Inventory.redBugs; 
        rBugText.text = "red bugs " + rBugCount;

        goldenCoins = Coins.getGoldenCoin();
        print("testing " + goldenCoins);
        coinsText.text = "X " + goldenCoins;

        silverCoins = Coins.getSilverCoin();
        print("testing " + silverCoins);
        silverCoinText.text = "X " + silverCoins;



        assignment();
        heartPoints();
        
    }

    // Update is called once per frame
    void heartPoints()
    {
        healthPoints = FoxScript.health;
        switch(healthPoints)
        {
            case 0:
                healthText.text = "0 points";
                break;

            case 1:
                heartImages[0].enabled = true;
                for(int x = 1; x <= 4; x++)
                {
                    heartImages[x].enabled = false;
                }
                //healthText.text = "❤";
                break;

            case 2:
                heartImages[0].enabled = true;
                heartImages[1].enabled = true;
                for (int x = 2; x <= 4; x++)
                {
                    heartImages[x].enabled = false;
                }
                break;

            case 3:
                for (int x = 0; x <= 2; x++)
                {
                    heartImages[x].enabled = true;
                }
                heartImages[3].enabled = false;
                heartImages[4].enabled = false;
                break;

            case 4:
                for (int x = 0; x <= 3; x++)
                {
                    heartImages[x].enabled = true;
                }
                heartImages[4].enabled = false;
                break;

            case 5:
                for (int x = 0; x <= 4; x++)
                {
                    heartImages[x].enabled = true;
                }
                break;

        }


           
    }

    void assignment()
    {
        for(int x = 0; x <= 4; x++)
        {
            heartObj[x] = GameObject.Find(h[x]);  // heart[0] = GameObject.Find("Heart1");
            heartImages[x] = heartObj[x].GetComponent<Image>();//heart1Image = heart1.GetComponent<Image>();
        }

    }

}
