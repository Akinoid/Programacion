using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeController : MonoBehaviour
{
    
    [SerializeField] Button Mejora1;
    [SerializeField] Button Mejora2;
    [SerializeField] Button Save;
    public Score Score;
    public TMP_Text scoreText;



    Mejora1 M1;
    Mejora2 M2;
    Save S;
    


    // Start is called before the first frame update
    private void Awake()
    {
        UpdateScoreText();
        Score = GetComponent<Score>();
        M1 = GetComponent<Mejora1>();
        M2 = GetComponent<Mejora2>();
        S = GetComponent<Save>();
        

        Mejora1.onClick.AddListener(M1.Comprar);
        Mejora2.onClick.AddListener(M2.UpgradeClick);

        

        Save.onClick.AddListener(() => S.SendScore(PlayerPrefs.GetInt("user_id"), Score.Points));
    }
   

    void Start()
    {
        
        UpdateScoreText();
    }

    void Update()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + Score.Points;
    }
}

