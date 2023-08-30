using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Base class for baloons. I don't see the point of interfaces in such a small project, plus my version of Unity doesn't have a default implementation.
/// Also, a better solution would be to write a separate BallonType.cs with an initiating method. But - KISS.
/// </summary>
public abstract class BaloonBase : MonoBehaviour
{
    [SerializeField] protected float _speedModificator; // For inspector.
    public float SpeedModificator 
    {
        get => _speedModificator;
        set 
        {
            _speedModificator = value;
        } 
    }


    [Serializable]
    public class Health
    {
        public int healthMin;
        public int healthMax;
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



    public abstract void Initialize();

    public void OnMouseDown()
    {
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
}
