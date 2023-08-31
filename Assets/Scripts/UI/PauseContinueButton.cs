using UnityEngine;
using UnityEngine.UI;

public class PauseContinueButton : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(CallPauseController);
    }


    public void CallPauseController()
    {
        PauseController.Pause();
        GameManager.Instance.userUI.ShowPauseUI(PauseController.paused);
    }
}
