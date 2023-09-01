using UnityEngine;

public class GameState : MonoBehaviour
{
    public static void NewGame()
    {
        GameScore.ResetScore();
        CurrentBaloons.ResetBaloons();
        GameHealth.ResetHealth();

        PauseController.Pause(false);

        GameManager.Instance.userUI.ShowPauseUI(false);
    }


    public static void GameOver()
    {
        PauseController.Pause(true);
        CurrentBaloons.ResetBaloons();
        GameHealth.ResetHealth();
        
        GameManager gameManager = GameManager.Instance;
        gameManager.userUI.ShowPauseUI(true);
        gameManager.leaderBoard.leaderBoardUI.ShowInputField();
    }


}
