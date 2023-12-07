using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeController : MonoBehaviour
{
    [SerializeField] Button Mejora1;
    [SerializeField] Button Mejora2;

    Mejora1 M1;




    // Start is called before the first frame update
    private void Awake()
    {
        M1 = GetComponent<Mejora1>();


        Mejora1.onClick.AddListener(M1.Comprar);
        
    }
}
