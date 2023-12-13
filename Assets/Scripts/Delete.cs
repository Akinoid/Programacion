using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Delete : MonoBehaviour
{
    [HideInInspector] public string serverURL = "http://localhost/Progra/Programacion/Delete_User.php";

    public void DeleteU(int user_id)
    {
        StartCoroutine(DeleteUser(user_id));
    }

    IEnumerator DeleteUser(int user_id)
    {
        WWWForm form = new WWWForm();
        form.AddField("user_id", user_id);
        


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Progra/Programacion/Delete_User.php", form))
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
