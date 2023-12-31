using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RegisterUser : MonoBehaviour
{
    public void SendUser(string correo, string contraseņa, string username)
    {
        StartCoroutine(Register(correo, contraseņa, username));
    }

    IEnumerator Register(string correo, string contraseņa, string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("correo", correo);
        form.AddField("contraseņa", contraseņa);
        form.AddField("username", username);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Progra/Programacion/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();

            if(www.result==UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
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
