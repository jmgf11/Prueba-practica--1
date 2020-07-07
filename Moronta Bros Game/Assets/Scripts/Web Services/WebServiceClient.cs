using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WebServiceClient : MonoBehaviour
{
    UnityWebRequest www;
    
    public void postPlayerScore(string player, int score, string path="https://isc210webapi.azurewebsites.net/api/S3score/0"){
        StartCoroutine(postNewScore(player, score, path));
    }

     public void getScores(string path="https://isc210webapi.azurewebsites.net/api/S3score/0"){
        StartCoroutine(getAllPlayerScores(path));
    }

    public IEnumerator postNewScore(string player, int score, string path="https://isc210webapi.azurewebsites.net/api/S3score/0")
    {
        PlayerScore playerScore = new PlayerScore();
        playerScore.PlayerName = player;
        playerScore.Score = score;

        www = UnityWebRequest.Put(path, JsonUtility.ToJson(playerScore));
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);
    }

    public IEnumerator getAllPlayerScores(string path){
        www = UnityWebRequest.Get(path);
        www.SetRequestHeader("Content-Type", "aplication/json");
        yield return www.SendWebRequest();
        PlayerScoreDomain data = JsonUtility.FromJson<PlayerScoreDomain>(www.downloadHandler.text);
        
        foreach (PlayerScore playerScore in data.scoreList)
        {
            Debug.Log(playerScore.PlayerName + " - " + playerScore.Score);
        }
        
    }
}
