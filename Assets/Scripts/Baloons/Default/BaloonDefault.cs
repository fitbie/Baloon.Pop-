using UnityEngine;

public class BaloonDefault : BaloonBase
{
    public override void Kill()
    {
        base.Kill();

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
        
        GameObject.Destroy(gameObject);
    }

}
