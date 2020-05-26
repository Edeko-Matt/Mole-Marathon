using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tokens : MonoBehaviour
{
    public static int coins;
    [SerializeField] Text tokenCount;
    void Start()
    {
       
    }

    void Update()
    {
        tokens();
    }

    public static int tokens()
    {
        coins = Coins.getSilverCoin() + Coins.getGoldenCoin();
        return coins;
    }
  
}
