using UnityEngine;

public class GameState : MonoBehaviour
{
    public static void NewGame()
    {
        ResetGame();

        PauseController.Pause(false);

        GameManager.Instance.userUI.ShowPauseUI(false);
    }


    public static void ResetGame()
    {
        GameScore.ResetScore();
        CurrentBaloons.ResetBaloons();
        GameHealth.ResetHealth();
    }


    public static void GameOver()
    {
        PauseController.Pause(true);
        ResetGame();
        
        GameManager gameManager = GameManager.Instance;
        gameManager.userUI.ShowPauseUI(true);
        gameManager.leaderBoard.leaderBoardUI.ShowInputField();
    }


}
