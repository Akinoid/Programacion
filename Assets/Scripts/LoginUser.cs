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
                int user_id;
                if (int.TryParse(www.downloadHandler.text, out user_id))
                {
                    Debug.Log("Éxito en loguearse. User ID: " + user_id);

                    // Almacenar el user_id como PlayerPrefs
                    PlayerPrefs.SetInt("user_id", user_id);
                    PlayerPrefs.Save();
                }
                else
                {
                    Debug.LogError("Error al convertir el user_id: " + www.downloadHandler.text);
                }

            }
        }
    }
}
