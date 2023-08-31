using UnityEngine;
using UnityEngine.UI;

public class NewRestartGameButton : MonoBehaviour
{
    private Button button;


    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(NewGame);
    }


    private void NewGame()
    {
        GameManager.Instance.gameState.NewGame();
    }
}
