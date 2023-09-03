using System.Collections.Generic;
using UnityEngine;
using PlayerScore = LeaderBoardController.PlayerScore;

public class LeaderBoardUI : MonoBehaviour
{
    [Header("UI Gameobjects")]
    [SerializeField] private Transform leaderUiElementsParent; // Content GO with Vertical Layout Group.

    [Space(3)]
    [SerializeField] private LeaderUIElement leaderUIPrefab;
    private List<LeaderUIElement> currentLeaders = new List<LeaderUIElement>();
    
    private GameManager gameManager;
    private LeaderBoardController leaderBoard;



    private void Start()
    {
        gameManager = GameManager.Instance;
        leaderBoard = gameManager.leaderBoard;    
    }


    // Also Called from inspector button. TODO.
    public void OpenLeaderBoard()
    {
        BuildLeaderboard();

        gameManager.userUI.ShowLeaderBoard(true);
    }


    private void BuildLeaderboard()
    {
        foreach (PlayerScore playerScore in leaderBoard.playerScores)
        {
            LeaderUIElement leader = GameObject.Instantiate(leaderUIPrefab, leaderUiElementsParent);

            leader.playerName.text = playerScore.name;
            leader.playerScore.text = playerScore.score.ToString();

            currentLeaders.Add(leader);
        }
    }


    // Called from inspector input field. TODO.
    public void InputName(string name)
    {
        leaderBoard.AddLeader(name, GameScore.Score);

        OpenLeaderBoard();

        gameManager.userUI.ShowMainMenu(true);
    }

    
    // Called from inspector button. TODO.
    public void CloseLeaderBoard()
    {
        gameManager.userUI.ShowLeaderBoard(false);

        for (int i = 0; i < currentLeaders.Count; i++)
        {
            GameObject.Destroy(currentLeaders[i].gameObject);
        }

        currentLeaders.Clear();
    }

}
