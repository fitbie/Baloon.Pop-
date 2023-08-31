using UnityEngine;

public class GameState : MonoBehaviour
{
    public void NewGame()
    {
        GameScore.ResetScore();
        CurrentBaloons.ResetBaloons();

        PauseController.Pause(false);

        GameManager.Instance.userUI.ShowPauseUI(false);
    }


    public void GameOver()
    {
        PauseController.Pause(true);
    }


}
