using UnityEngine;

public class GameState : MonoBehaviour
{
    private static UserUIController userUIController;

    public static void NewGame()
    {
        if (userUIController == null) { userUIController = GameManager.Instance.userUI; }

        GameScore.ResetScore();
        CurrentBaloons.ResetBaloons();
        GameHealth.ResetHealth();

        PauseController.Pause(false);

        userUIController.ShowPauseUI(false);
        userUIController.ShowInputField(false);
    }


    public static void GameOver()
    {
        PauseController.Pause(true);

        CurrentBaloons.ResetBaloons();
        GameHealth.ResetHealth();

        userUIController.ShowUserUIMainPanel(false);
        userUIController.ShowInputField(true);
    }


}
