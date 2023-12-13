using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Save : MonoBehaviour
{
   
    [HideInInspector]public string serverURL = "http://localhost/Progra/Programacion/Update_Score.php";
   

    public void SendScore(int user_id, float score)
    {
        StartCoroutine(UpdateScore(user_id, score));
    }

    IEnumerator UpdateScore(int user_id, float score)
    {
        WWWForm form = new WWWForm();
        form.AddField("user_id", user_id);
        form.AddField("score", (int)score);
    

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Progra/Programacion/Update_Score.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Puntuación actualizada con éxito");
            }
            else
            {
                Debug.LogError("Error al actualizar la puntuación: " + www.error);
            }
        }




    }
}


