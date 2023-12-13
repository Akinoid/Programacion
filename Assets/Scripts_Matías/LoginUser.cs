using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoginUser : MonoBehaviour
{
    public void SendUserLogin(string correo, string contrase�a)
    {
        StartCoroutine(Login(correo, contrase�a));
    }

    IEnumerator Login(string correo, string contrase�a)
    {
        WWWForm form = new WWWForm();
        form.AddField("correo", correo);
        form.AddField("contrase�a", contrase�a);

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
