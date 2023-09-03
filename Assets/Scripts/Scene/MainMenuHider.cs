using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(1)] // Execute after all thread, so other scripts will initialize.

/// <summary>
/// Silly class that hides the main menu and opens UserUI. TODO.
/// </summary>
public class MainMenuHider : MonoBehaviour
{
    [SerializeField] private GameObject useruiMainPanel;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private Button newGameButton;
    [SerializeField] private Animator animator;

    void Start()
    {
        HideUserUI();
        newGameButton.onClick.AddListener(NewGameUISetup);
    }

    public void HideUserUI()
    {
        mainMenuPanel.SetActive(true);
        useruiMainPanel.SetActive(false);
    }

    private void NewGameUISetup()
    {
        useruiMainPanel.SetActive(true);
        animator.SetTrigger("hide");
        
    }


    // Called from animator
    public void Deactivate()
    {
        mainMenuPanel.SetActive(false);
    }
}
