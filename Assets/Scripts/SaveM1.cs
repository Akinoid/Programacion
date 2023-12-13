using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SaveM1 : MonoBehaviour
{
    [HideInInspector] public string serverURL = "http://localhost/Progra/Programacion/Insert_Upgrade.php";


    public void SendM1(int user_id, int amount)
    {
        StartCoroutine(UpdateM1Amount(user_id, amount));

    }

    IEnumerator UpdateM1Amount(int user_id, int amount)
    {
        WWWForm form = new WWWForm();
        form.AddField("user_id", user_id);
        form.AddField("upgrade_id", 1);
        form.AddField("amount", amount);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Progra/Programacion/Insert_Upgrade.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Puntuaci�n actualizada con �xito");
            }
            else
            {
                Debug.LogError("Error al actualizar la puntuaci�n: " + www.error);
            }
        }




    }

}
