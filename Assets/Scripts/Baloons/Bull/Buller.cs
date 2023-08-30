using UnityEngine;

/// <summary>
/// Attach to object to make it bull. Kills other baloons, but has high speed. Use default baloon.
/// </summary>
[RequireComponent(typeof(BaloonBase), typeof(Collider2D))]
public class Buller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<BaloonBase>(out BaloonBase baloon))
        {
            baloon.Kill();
        }
    }

}
