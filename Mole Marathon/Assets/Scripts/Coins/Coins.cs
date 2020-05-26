using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{

    public GameObject[] goldenCoins;
    public GameObject[] silverCoins;
    [SerializeField] Text tokensText;
    GameObject mole;
    public Vector3 molePos; 
    public Vector3 moleToCoinDistance;
    public int goldenCoinCounter = 1;
    public int silverCoinCounter = 1;
    public static int gCoin;
    public static int sCoin;
    public static int total;
    void Start()
    {
       silverCoins = GameObject.FindGameObjectsWithTag("silver");
       goldenCoins = GameObject.FindGameObjectsWithTag("gold"); 
       mole = GameObject.Find("character");
    }

   
    void Update()
    {
       tokensText.text = "" + GettotalCoin();
       molePos = mole.transform.position;
       goldenCoinConsumed();
       silverCoinConsumed();

    }

    
    public void goldenCoinConsumed()
    {
  
        foreach (GameObject g in goldenCoins)
        {
            moleToCoinDistance = g.transform.position - molePos;
            float distance = moleToCoinDistance.sqrMagnitude;
         
            if (distance < 1.5)// 1.3
            {
                g.GetComponent<Renderer>().enabled = false;
                
                gCoin = goldenCoinCounter++;
                StartCoroutine("Pause");
                print("gold " + gCoin);
                g.transform.position = new Vector3(-500, -500, -500);
            }
           
        }
      
    }

    public void silverCoinConsumed()
    {

        foreach (GameObject s in silverCoins)
        {
            moleToCoinDistance = s.transform.position - molePos;
            float distance = moleToCoinDistance.sqrMagnitude;

            if (distance < 1.5)
            {
                s.GetComponent<Renderer>().enabled = false;

                sCoin = silverCoinCounter++;
                StartCoroutine("Pause");
                print("silver " + sCoin);
                s.transform.position = new Vector3(-500, -500, -500);
            }

        }
      
    }

    public static  void setGoldenCoin( int gold)
    {
        gCoin = gold;
    }

    public static void setSilverCoin(int silver)
    {
         sCoin = silver;
    }
    public static int getGoldenCoin()
    {
        return gCoin;
    }

    public static int getSilverCoin()
    {
        return sCoin;
    }
    public static int GettotalCoin()
    {
        total = getGoldenCoin() + getSilverCoin();
        return total;
    }

    public static void SettotalCoin(int newCoin)
    {
        total = newCoin;
    }

    IEnumerator Pause()
    {
        enabled = false;

        yield return new WaitForSeconds(0.05f); 

        enabled = true;

    }
}
