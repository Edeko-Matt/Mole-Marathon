using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    
    public Button[] storeButtons = new Button[3];
    [SerializeField] Text currentTokens;
    [SerializeField] Text pwUp1BoughtText;
    [SerializeField] Text pwUp2BoughtText;
    [SerializeField] Text pwUp3BoughtText;

  
    public static int coins;
    public static int currentCoins;
    public static int PowerUp1Bought;
    public static int PowerUp2Bought;
    public static int PowerUp3Bought;
    void Start()
    {
        currentCoins = Coins.getSilverCoin() + Coins.getGoldenCoin(); //initial number of coins
        currentTokens.text = "You have " + currentCoins + " tokens!";
        storeButtons[0] = GameObject.Find("P#1").GetComponent<Button>();
        storeButtons[0].onClick.AddListener(buyPowerUp1);
        storeButtons[1] = GameObject.Find("P#2").GetComponent<Button>();
        storeButtons[1].onClick.AddListener(buyPowerUp2);
        storeButtons[2] = GameObject.Find("P#3").GetComponent<Button>();
        storeButtons[2].onClick.AddListener(buyPowerUp3);
    }

    // Update is called once per frame
    void Update()
    {
        currentTokens.text = "You have " +currentCoins  + " tokens!";
        Coins.SettotalCoin(currentCoins);
    }

   

    void buyPowerUp1() // need 5 tokens
    {
        if(currentCoins >= 5)
        {
            currentCoins = currentCoins - 5;
            print(currentCoins + "current coins");
            Coins.setGoldenCoin(0);
            Coins.setSilverCoin(currentCoins);
            Coins.SettotalCoin(currentCoins);
            print(Coins.GettotalCoin() +" after buy a p1" );
           
            PowerUp1Bought = PowerUp1Bought += 1;
            pwUp1BoughtText.text = PowerUp1Bought + " power up #1 ";
        }
        else
        {
            pwUp1BoughtText.text = "Can't buy";
        }
        
    }

    void buyPowerUp2() // need 2 tokens
    {
        if (currentCoins >= 2)
        {
            currentCoins = currentCoins - 2;
            Coins.SettotalCoin(currentCoins);
            Coins.setGoldenCoin(0);
            Coins.setSilverCoin(currentCoins);
            PowerUp2Bought = PowerUp2Bought += 1;
            pwUp2BoughtText.text = PowerUp2Bought + " power up #2 ";
        }
        else
        {
            pwUp2BoughtText.text = "Can't buy";
        }

    }

    void buyPowerUp3() // need 3 tokens
    {
        if (currentCoins >= 3)
        {
            currentCoins = currentCoins - 3;
            Coins.SettotalCoin(currentCoins);
            Coins.setGoldenCoin(0);
            Coins.setSilverCoin(currentCoins);
            PowerUp3Bought = PowerUp3Bought += 1;
            pwUp3BoughtText.text = PowerUp3Bought + " power up #3 ";
        }
        else
        {
            pwUp3BoughtText.text = "Can't buy";
        }
    }

  
}
