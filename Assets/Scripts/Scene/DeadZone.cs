using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.TryGetComponent<BaloonBase>(out BaloonBase baloon))
        {
            baloon.Die();
        }    
    }
}
