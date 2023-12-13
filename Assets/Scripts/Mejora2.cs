using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mejora2 : MonoBehaviour
{
    Click CScore;

    private void Awake()
    {
        CScore = GetComponent<Click>();
    }

    public void UpgradeClick()
    {
        CScore.ClickScore = CScore.ClickScore +1;
    }
    
}
