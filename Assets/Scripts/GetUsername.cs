using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class GetUsername : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI usernameText;
    public void GetUser()
    {
        StartCoroutine(Get());
    }

    IEnumerator Get()
    {
        WWWForm form = new WWWForm();
        form.AddField("user_id", PlayerPrefs.GetInt("user_id"));

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Progra/Programacion/GetUsername.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                usernameText.text = $"Usuario: {www.downloadHandler.text}";
            }
        }
    }
}
