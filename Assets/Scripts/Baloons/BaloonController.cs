using UnityEngine;


[RequireComponent(typeof(BaloonBase))]
public class BaloonController : MonoBehaviour
{
    private BaloonBase baloon;


    private void Start()
    {
        if (TryGetComponent<BaloonBase>(out BaloonBase _baloon))
        {
            baloon = _baloon;
        }
    }


    private void Update()
    {
        Move();
    }


    private void Move()
    {
        Vector3 velocity = new Vector3(0, baloon.speedModificator.CurrentSpeed * Time.deltaTime, 0);
        transform.Translate(velocity);
    }
}
