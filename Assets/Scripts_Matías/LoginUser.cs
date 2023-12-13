using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoginUser : MonoBehaviour
{
    public void SendUserLogin(string correo, string contraseña)
    {
        StartCoroutine(Login(correo, contraseña));
    }

    IEnumerator Login(string correo, string contraseña)
    {
        WWWForm form = new WWWForm();
        form.AddField("correo", correo);
        form.AddField("contraseña", contraseña);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Progra/Programacion/LoginUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
