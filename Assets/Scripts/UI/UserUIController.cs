using UnityEngine;
using UnityEngine.UI;

public class UserUIController : MonoBehaviour
{
    public ScoreUI scoreUI;
    public HealthUI healthUI;
    
    [Space(3)]
    [SerializeField] private GameObject userUiMainPanel;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button pauseButton;

    [Header("Leaderboard")]
    [SerializeField] private GameObject leaderboardInputField;
    [SerializeField] private GameObject leaderboardPanel;


    public void ShowUserUIMainPanel(bool state)
    {
        userUiMainPanel.SetActive(state);
    }


    public void ShowMainMenu(bool state)
    {
        mainMenu.SetActive(state);
    }


    public void ShowPauseUI(bool state)
    {
        if (pauseButton.interactable == state) { pauseButton.interactable = !state; } // button interactable should be opposite to pause state 
        if (pausePanel.activeSelf != state) { pausePanel.SetActive(state); }
    }


    public void ShowInputField(bool state)
    {
        leaderboardInputField.SetActive(state);
    }


    public void ShowLeaderBoard(bool state)
    {
        leaderboardPanel.SetActive(state);
    }

}
