using UnityEngine;

public class GameHealth : MonoBehaviour
{
    public static int MaxHealth { get; private set; } = 3;
    public static int Health { get; private set; }


    public static void RemoveHP(int value)
    {
        Health += value;

        if (Health <= 0)
        {
            GameState.GameOver();
            return;
        }

        GameManager.Instance.userUI.healthUI.RemoveHearts(value);
    }
}
