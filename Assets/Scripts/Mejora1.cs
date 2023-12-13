using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mejora1 : MonoBehaviour
{

    public Score Points;
    public int buy;
    public float timer, maxTimer;

    private void Awake()
    {
        Points = GetComponent<Score>();
    }
    void Start()
    {
        maxTimer = 1;
    }

    void Update()
    {
        Mejora();
    }

    public void Comprar()
    {
        buy++;
    }


    public void Mejora()
    {
        if(buy > 0)
        {
            timer += Time.deltaTime;
            if(timer >= maxTimer)
            {
                timer = 0;
                Points.Increment(0.5f * buy);

            }
        }
    }
}
