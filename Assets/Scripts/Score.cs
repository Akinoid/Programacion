using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float Points = 0;
    
    public void Increment(float ClickBuff)
    {
        Points+=ClickBuff;
    }
    
}
