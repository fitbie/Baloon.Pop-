using UnityEngine;


/// <summary>
/// Usually called from baloons prefab -> onDie UnityEvent in inspector.
/// </summary>
public class CallCMShake : MonoBehaviour
{
    [SerializeField] private float shakeTime = 0.1f;


    public void Shake()
    {
        GameManager.Instance.cinemachineController.StartShake(shakeTime);
    }
}
