using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mejora1 : MonoBehaviour
{

    public float score;
    public float buy;
    public float timer, maxTimer;

    void Start()
    {
        maxTimer = 1;
    }

    void Update()
    {
        Mejora();
    }

    void Mejora()
    {
        if(buy > 0)
        {
            timer += Time.deltaTime;
            if(timer >= maxTimer)
            {
                timer = 0;
                score += 0.5f * buy;

            }
        }
    }
}
