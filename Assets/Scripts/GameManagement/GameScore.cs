public class GameScore
{
    public static int Score { get; private set; }


    public static void ModifyScore(int value)
    {
        Score += value;

        GameManager gameManager = GameManager.Instance;
        if (Score < 0) { GameState.GameOver(); }

        gameManager.userUI.scoreUI.UpdateScoreText(Score);
    }


    public static void ResetScore()
    {
        ModifyScore(-Score);
    }
}
