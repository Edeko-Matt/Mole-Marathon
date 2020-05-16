using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPosition : MonoBehaviour
{
    private float screenWidth;
    private float screenHeight;
    private float x = -7f;      // 1 == 90 pixels
    private float y = 6;        // 1 == 
    private Vector3 hUI;
    private Vector3 tUI;
    public RectTransform healthUI; 
    public RectTransform healthSymbol; 
    public RectTransform tokensUI; 
    public RectTransform tokensSymbol; 
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        calculateUI();
    }
    private void calculateUI()
    {
        hUI = new Vector3(x, y, 0);
        healthUI.gameObject.transform.position = hUI;
        healthSymbol.gameObject.transform.position = hUI += new Vector3(1.6f, y-6, 0);

        y = -4;
        tUI = new Vector3(x, y, 0);
        tokensUI.gameObject.transform.position = tUI;
        tokensSymbol.gameObject.transform.position = tUI += new Vector3(1.6f, y+4, 0);



    }
}
