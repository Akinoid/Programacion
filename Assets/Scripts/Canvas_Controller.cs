using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Canvas_Controller : MonoBehaviour
{
    public GameObject panel_Jugar;
    public GameObject panel_Login;
    public GameObject panel_Register;
    public GameObject panel_LorR;
    private void Awake()
    {
        panel_Jugar = transform.Find("Panel_Jugar").gameObject;
        panel_Jugar.SetActive(false);
        panel_Login = transform.Find("Panel_Login").gameObject;
        panel_Login.SetActive(false);
        panel_Register = transform.Find("Panel_Register").gameObject;
        panel_Register.SetActive(false);
        panel_LorR = transform.Find("Panel_LorR").gameObject;
        panel_LorR.SetActive(true);

    }

    public void Login_Button()
    {
        panel_Login.SetActive(true);
        panel_LorR.SetActive(false);
    }

    public void Register_Button()
    {
        panel_Register.SetActive(true);
        panel_LorR.SetActive(false);
    }

    public void Enter_Button()
    {
        panel_Jugar.SetActive(true);
        panel_Login.SetActive(false);
    }

    public void Enter_ButtonR()
    {
        panel_Login.SetActive(true);
        panel_Register.SetActive(false);
    }

    public void Volver_Button_Play_Panel()
    {
        panel_LorR.SetActive(true);
        panel_Jugar.SetActive(false);
    }

    public void Volver_Button_Login_Panel()
    {
        panel_LorR.SetActive(true);
        panel_Login.SetActive(false);
    }

    public void Volver_Button_Register_Panel()
    {
        panel_LorR.SetActive(true);
        panel_Register.SetActive(false);
    }


    public void OnClickJugar()
    {
        SceneManager.LoadScene("Nivel");
    }
}
