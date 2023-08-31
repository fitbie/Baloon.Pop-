using System.Data;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq; // I know you expect OrderBy() :)


public class LeaderBoardController : MonoBehaviour
{
    [Serializable]
    public class PlayerScore
    {
        public string name;
        public int score;

        public PlayerScore(string playerName, int playerScore)
        {
            this.name = playerName;
            this.score = playerScore;
        }
    }
    public List<PlayerScore> playerScores = new List<PlayerScore>();



    private void Start()
    {
        Initialize();
    }

    
    private void Initialize()
    {
        LoadLeaders();

        playerScores.Sort((a, b) => b.score.CompareTo(a.score));
    }


    public void AddLeader(string name, int score)
    {
        PlayerScore playerScore = new PlayerScore(name, score);
        playerScores.Add(playerScore);

        SaveLeaders();
    }


//--------------------------------------TODO: MAKE SEPARATE JSON/BINARY SAVER. BUT FOR NOW IT'S TOO MUCH.--------------------------------------

    private string key = "playerScoresPrefsKey";


    [Serializable]
    public class SaveData // BC Json doesn't save lists without wrapper.
    {
        public List<PlayerScore> playerScores = new List<PlayerScore>();
    }


    private void SaveLeaders()
    {
        SaveData data = new SaveData();
        data.playerScores.AddRange(playerScores);

        string jsonPlayerScores = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(key, jsonPlayerScores);
        PlayerPrefs.Save();
    }


    private void LoadLeaders()
    {
        string jsonPlayerScores = PlayerPrefs.GetString(key);

        SaveData data = JsonUtility.FromJson<SaveData>(jsonPlayerScores); 
        
        playerScores.AddRange(data.playerScores);
    }
    
}
