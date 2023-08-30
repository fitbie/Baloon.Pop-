using UnityEngine;


/// <summary>
/// Usually called from baloons prefab -> onDie UnityEvent in inspector.
/// </summary>
public class CallVibration : MonoBehaviour
{
    [SerializeField] private long ms = 200;


    public void Vibrate()
    {
        Vibration.Vibrate(ms);
    }
}
