using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Base class for baloons. I don't see the point of interfaces in such a small project, plus my version of Unity doesn't have a default implementation.
/// </summary>
public abstract class BaloonBase : MonoBehaviour
{
    public abstract int Health { get; set; }

    public abstract float SpeedModificator { get; set; }

    [Serializable]
    public class BaloonsEvents
    {
        public UnityEvent onPop;
        public UnityEvent onKill;
        public UnityEvent onFlew;
        public UnityEvent onDie;
    }
    
    public BaloonsEvents baloonsEvents = new BaloonsEvents();




    public void OnMouseDown()
    {
        Pop();
    }

    public abstract void Pop();

    public abstract void Kill();

    public abstract void Flew();

    public abstract void Die();
}
