using UnityEngine;

public class GameState : MonoBehaviour
{
    public static void NewGame()
    {
        GameScore.ResetScore();
        CurrentBaloons.ResetBaloons();

        PauseController.Pause(false);

        GameManager.Instance.userUI.ShowPauseUI(false);
    }


    public static void GameOver()
    {
        PauseController.Pause(true);

        GameManager.Instance.leaderBoard.leaderBoardUI.ShowInputField();
    }


}
