using UnityEngine;

public class GameHealth
{
    public static int MaxHealth { get; private set; } = 3;
    public static int Health { get; private set; } = MaxHealth;


    public static void Modify(int value)
    {
        Health += value;

        if (Health <= 0)
        {
            GameState.GameOver();
            return;
        }

        GameManager.Instance.userUI.healthUI.ChangeHearts(Mathf.Abs(value));
    }


    public static void ResetHealth()
    {
        Health = MaxHealth;

        GameManager.Instance.userUI.healthUI.ResetHealthUI();
    }
}
