using UnityEngine;

public class PauseController
{
    public static bool paused { get; private set; } = true;    


    public static void Pause(bool pauseGame)
    {
        PauseController.paused = pauseGame;
        Time.timeScale = pauseGame ? 0 : 1;
    }
}
