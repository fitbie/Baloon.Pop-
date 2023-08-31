using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// When added to a game object, you must specify enum is a pause or continue button.
/// </summary>
public class PauseContinueButton : MonoBehaviour
{
    public enum ButtonType { Pause, Continue }
    [SerializeField] private ButtonType buttonType;


    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(CallPauseController);
    }


    public void CallPauseController()
    {
        bool pauseGame = buttonType == ButtonType.Pause ? true : false;
        PauseController.Pause(pauseGame);
        GameManager.Instance.userUI.ShowPauseUI(PauseController.paused);
    }
}
