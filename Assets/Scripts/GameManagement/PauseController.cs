using UnityEngine;

public class PauseController : MonoBehaviour
{
    public static bool paused = true;

    private UserUIController userUI;
    
    private void Start()
    {
        userUI = GameManager.Instance.userUI;    
    }

    public void Pause()
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


    private void SetPause()
    {
        Time.timeScale = 0;
        paused = true;
        
        userUI.ShowPauseUI(paused);
    }


    private void SetUnpause()
    {
        Time.timeScale = 1;
        paused = false;

        userUI.ShowPauseUI(paused);
    }
}
