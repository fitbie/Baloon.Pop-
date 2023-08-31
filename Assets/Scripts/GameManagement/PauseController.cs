using UnityEngine;

public class PauseController
{
    public static bool paused = true;    


    // Called from inspector Pause/Continue buttons on UserUI.
    public static void Pause()
    {
        if(paused)
        {
            SetUnpause();
        }
        else
        {
            SetPause();
        }
    }


    private static void SetPause()
    {
        Time.timeScale = 0;
        paused = true;
    }


    private static void SetUnpause()
    {
        Time.timeScale = 1;
        paused = false;
    }
}
