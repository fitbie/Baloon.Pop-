using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Base class for baloons. I don't see the point of interfaces in such a small project, plus my version of Unity doesn't have a default implementation.
/// Also, a better solution would be to write a separate BallonType.cs with an initiating method. But - KISS.
/// </summary>
public abstract class BaloonBase : MonoBehaviour
{
    [Serializable]
    public class SpeedModificator
    {
        public float speedMin;
        public float speedMax;
        public float CurrentSpeed { get; set; }

        public void SetSpeed()
        {
            CurrentSpeed = UnityEngine.Random.Range(speedMin, speedMax);
        }
    }
    public SpeedModificator speedModificator;

    // Yeah, i could write 1 class for Health & Speed, but i need inspector & quick access.

    [Serializable]
    public class Health
    {
        [SerializeField] private int healthMin;
        [SerializeField] private int healthMax;
        public int CurrentHealth { get; set; }

        public void SetHealth()
        {
            CurrentHealth = UnityEngine.Random.Range(healthMin, healthMax);
        }
    }
    public Health health;



    [Serializable]
    public class BaloonsEvents
    {
        public UnityEvent onPop;
        public UnityEvent onKill;
        public UnityEvent onFlew;
        public UnityEvent onDie;
    }
    public BaloonsEvents baloonsEvents = new BaloonsEvents();


    public virtual void OnEnable() 
    { 
        health.SetHealth();
        speedModificator.SetSpeed();

        CurrentBaloons.AddBaloon(this);
    }


    public void OnMouseDown()
    {
        if (PauseController.paused) { return; }

        Pop();
    }

    public virtual void Pop()
    { 
        baloonsEvents.onPop?.Invoke();
        
        health.CurrentHealth--;
        if (health.CurrentHealth <= 0) { Kill(); }
    }

    public virtual void Kill() { baloonsEvents.onKill?.Invoke(); }

    public virtual void Flew() { baloonsEvents.onFlew?.Invoke(); }

    public virtual void Die() { baloonsEvents.onDie?.Invoke(); }


    public virtual void OnDisable() { CurrentBaloons.RemoveBaloon(this); }

}
