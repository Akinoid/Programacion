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
    [SerializeField] Button Delete;
    public Score Score;
    public TMP_Text scoreText;

    Delete D;

    Mejora1 M1;
    Mejora2 M2;

    SaveM1 SM1;
    SaveM2 SM2;

    Save S;
    


    // Start is called before the first frame update
    public void Awake()
    {

        UpdateScoreText();
        Score = GetComponent<Score>();
        M1 = GetComponent<Mejora1>();
        M2 = GetComponent<Mejora2>();
        S = GetComponent<Save>();
        D = GetComponent<Delete>();
        SM1 = GetComponent<SaveM1>();
        SM2 = GetComponent<SaveM2>();


        Mejora1.onClick.AddListener(M1.Comprar);
        Mejora2.onClick.AddListener(M2.UpgradeClick);

        Delete.onClick.AddListener(() => D.DeleteU(PlayerPrefs.GetInt("user_id")));

        Save.onClick.AddListener(() => S.SendScore(PlayerPrefs.GetInt("user_id"), Score.Points));

        Save.onClick.AddListener(() => SM1.SendM1(PlayerPrefs.GetInt("user_id"), M1.M1_buy));

        Save.onClick.AddListener(() => SM2.SendM2(PlayerPrefs.GetInt("user_id"), M2.M2_buy));

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

