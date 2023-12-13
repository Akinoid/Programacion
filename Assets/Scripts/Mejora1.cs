using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mejora1 : MonoBehaviour
{
    public int precio = 20;
    public Score Points;
    public int M1_buy=0;
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
        if (Points.Points >= precio)
        {
            Points.Points -= precio;
            M1_buy++;
            
        }
        else
        {
            Debug.Log("No alcanza");
        }
       
    }


    public void Mejora()
    {
        if(M1_buy > 0)
        {
            timer += Time.deltaTime;
            if(timer >= maxTimer)
            {
                timer = 0;
                Points.Increment(0.5f * M1_buy);

            }
        }
    }
}
