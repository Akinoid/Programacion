using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class RegisterUserTMP : MonoBehaviour
{
    [SerializeField] private TMP_InputField correoInputField;
    [SerializeField] private TMP_InputField contraseñaInputField;
    [SerializeField] private TMP_InputField usernameInputField;
    [SerializeField] private Button sendUser;
    private RegisterUser registerUser;

    private void Awake()
    {
        registerUser = GetComponent<RegisterUser>();
        sendUser.onClick.AddListener(OnSendRegister);
    }

    private void OnSendRegister()
    {
        registerUser.SendUser(correoInputField.text, contraseñaInputField.text, usernameInputField.text);
    }
}
