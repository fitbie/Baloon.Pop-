using System.Collections.Generic;
using UnityEngine;
using PlayerScore = LeaderBoardController.PlayerScore;

public class LeaderBoardUI : MonoBehaviour
{
    [Header("UI Gameobjects")]
    [SerializeField] private GameObject leaderboardPanel;
    [SerializeField] private GameObject inputField;
    [SerializeField] private Transform content; // Parent with Vertical Layout Group.

    [Space(3)]
    [SerializeField] private LeaderUIElement leaderUIPrefab;
    private List<LeaderUIElement> currentLeaders = new List<LeaderUIElement>();
    
    private LeaderBoardController leaderBoard;



    private void Start()
    {
        leaderBoard = GameManager.Instance.leaderBoard;    
    }


    // Called from inspector button. TODO.
    public void OpenLeaderBoard()
    {
        BuildLeaderboard();

        leaderboardPanel.SetActive(true);
    }


    private void BuildLeaderboard()
    {
        foreach (PlayerScore playerScore in leaderBoard.playerScores)
        {
            LeaderUIElement leader = GameObject.Instantiate(leaderUIPrefab, content);

            leader.playerName.text = playerScore.name;
            leader.playerScore.text = playerScore.score.ToString();

            currentLeaders.Add(leader);

        }
    }


    public void ShowInputField()
    {
        inputField.SetActive(true);
    }


    // Called from inspector input field. TODO.
    public void InputName(string name)
    {
        leaderBoard.AddLeader(name, GameScore.Score);

        OpenLeaderBoard();
    }

    
    // Called from inspector button. TODO.
    public void CloseLeaderBoard()
    {
        leaderboardPanel.SetActive(false);

        for (int i = 0; i < currentLeaders.Count; i++)
        {
            GameObject.Destroy(currentLeaders[i].gameObject);
        }

        currentLeaders.Clear();
    }

}
