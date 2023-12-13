using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class LoginUserTMP : MonoBehaviour
{
    [SerializeField] private TMP_InputField correoInputField;
    [SerializeField] private TMP_InputField contraseñaInputField;
    [SerializeField] private Button sendUser;
    private LoginUser loginUser;

    private void Awake()
    {
        loginUser = GetComponent<LoginUser>();
        sendUser.onClick.AddListener(OnSendLogin);
    }

    private void OnSendLogin()
    {
        loginUser.SendUserLogin(correoInputField.text, contraseñaInputField.text);
    }
}
