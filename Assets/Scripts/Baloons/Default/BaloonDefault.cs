using UnityEngine;

public class BaloonDefault : BaloonBase
{
    public override void Kill()
    {
        base.Kill();
        
        GameScore.ModifyScore(scorePointsModificator.ScoreReward);

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
        
        GameScore.ModifyScore(scorePointsModificator.ScorePenalty);

        GameObject.Destroy(gameObject);
    }

}
