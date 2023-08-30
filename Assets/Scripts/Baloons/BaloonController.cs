using UnityEngine;


[RequireComponent(typeof(BaloonBase), typeof(Rigidbody2D))]
public class BaloonController : MonoBehaviour
{
    private BaloonBase baloon;
    private Rigidbody2D rb;


    private void Start()
    {
        if (TryGetComponent<BaloonBase>(out BaloonBase _baloon) && TryGetComponent<Rigidbody2D>(out Rigidbody2D _rb))
        {
            baloon = _baloon;
            rb = _rb;
        }
    }


    private void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {
        rb.velocity = new Vector2(0, baloon.speedModificator.CurrentSpeed);
    }
}
