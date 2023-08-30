using UnityEngine;

public class BaloonBomb : BaloonBase
{
    public override void Kill()
    {
        base.Kill();
        
        GameScore.ModifyScore(scorePointsModificator.ScorePenalty);

        Vibration.Vibrate(200);
        GameObject.Destroy(gameObject);
    }


    public override void Flew()
    {
        base.Flew();

        Die();
    }


    public override void Die()
    {
        base.Die();
        
        GameScore.ModifyScore(scorePointsModificator.ScoreReward);

        GameObject.Destroy(gameObject);
    }

}
