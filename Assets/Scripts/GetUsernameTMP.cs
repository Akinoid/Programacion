using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUsernameTMP : MonoBehaviour
{
    [SerializeField] private Button loginEnterButton;
    private GetUsername getUsername;

    private void Awake()
    {
        getUsername = GetComponent<GetUsername>();
        loginEnterButton.onClick.AddListener(GetUserName);
    }
    private void GetUserName()
    {
        getUsername.GetUser();
    }
}
