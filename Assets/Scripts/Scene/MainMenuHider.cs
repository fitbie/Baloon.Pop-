using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(1)] // Execute after all thread, so other scripts will initialize.

/// <summary>
/// Silly class that hides the main menu and opens UserUI. TODO.
/// </summary>
public class MainMenuHider : MonoBehaviour
{
    [SerializeField] private GameObject useruiMainPanel;
    [SerializeField] private Button newGameButton;
    [SerializeField] private Animator animator;

    void Start()
    {
        useruiMainPanel.SetActive(false);
        newGameButton.onClick.AddListener(NewGameUISetup);
    }

    private void NewGameUISetup()
    {
        useruiMainPanel.SetActive(true);
        animator.SetTrigger("hide");
        
    }


    // Called from animator
    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
