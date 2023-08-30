using System.Collections;
using System.Collections.Generic;
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
        // Add points
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
        // Remove points
        GameObject.Destroy(gameObject);
    }

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }
}
