using UnityEngine;

public class BaloonDefault : BaloonBase
{
    public void Start()
    {
        health.SetHealth();
        speedModificator.SetSpeed();
    }
    

    public override void Kill()
    {
        base.Kill();
        
        GameScore.ModifyScore(scorePointsModificator.ScoreReward);

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
        
        GameScore.ModifyScore(scorePointsModificator.ScorePenalty);

        GameObject.Destroy(gameObject);
    }

}
