using UnityEngine;
using UnityEngine.UI;

public class UserUIController : MonoBehaviour
{
    public ScoreUI scoreUI;
    
    [Space(3)]
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;


    // Called from inspector Pause/Continue buttons on UserUI.
    public void ShowPauseUI(bool state)
    {
        pauseButton.interactable = !state;
        pausePanel.SetActive(state);
    }
}
