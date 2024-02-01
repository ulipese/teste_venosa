using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[System.Serializable]
public class UserData 
{
    public string redCode;
    public string greenCode;
    public string blueCode;
}
    
public class callAPI : MonoBehaviour
{

    private string URL = "http://localhost:3001/colors";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public IEnumerator GetData() 
    {
        using(UnityWebRequest request = UnityWebRequest.Get(URL)) 
        {
            yield return request.SendWebRequest();

            if(request.result == UnityWebRequest.Result.Success) 
            {
                string responseText = request.downloadHandler.text;
                UserData userData = JsonUtility.FromJson<UserData>(responseText);
                Debug.Log(userData);
            }
            else 
            {
                Debug.LogError(request.error);
            }
        }

    }
}
