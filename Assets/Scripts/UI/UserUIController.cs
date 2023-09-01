using UnityEngine;
using UnityEngine.UI;

public class UserUIController : MonoBehaviour
{
    public ScoreUI scoreUI;
    public HealthUI healthUI;
    
    [Space(3)]
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;



    public void ShowPauseUI(bool state)
    {
        if (pauseButton.interactable == state) { pauseButton.interactable = !state; } // button interactable should be opposite to pause state 
        if (pausePanel.activeSelf != state) { pausePanel.SetActive(state); }
    }

}
