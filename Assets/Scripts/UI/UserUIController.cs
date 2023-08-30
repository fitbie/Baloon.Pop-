using UnityEngine;
using UnityEngine.UI;

public class UserUIController : MonoBehaviour
{
    public ScoreUI scoreUI;
    
    [Space(3)]
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;


    public void ShowPauseUI(bool state)
    {
        pauseButton.interactable = !state;
        pausePanel.SetActive(state);
    }
}
