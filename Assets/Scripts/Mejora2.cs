using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mejora2 : MonoBehaviour
{
    public int precio = 10;
    Click CScore;
    public int M2_buy=0;
    Score S;


    private void Awake()
    {
        S = GetComponent<Score>();
        CScore = GetComponent<Click>();
    }

    public void UpgradeClick()
    {
        if(S.Points>=precio)
        {
            S.Points -= precio;
            M2_buy++;
            CScore.ClickScore = 1 + M2_buy;
        }
        else
        {
            Debug.Log("No alcanza");
        }
        
    }
    
}
