using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Collide");
        if (other.gameObject.TryGetComponent<BaloonBase>(out BaloonBase baloon))
        {
            baloon.Die();
        }    
    }
}
