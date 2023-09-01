using UnityEngine;


/// <summary>
/// Changes the amount of health. Usually called from the OnKill/OnDie UnityEvents in inspector.
/// </summary>
public class ModifyHealth : MonoBehaviour
{
    [SerializeField] private int valueToChange;


    public void ChangeHealth()
    {
        GameHealth.Modify(valueToChange);
    }
}
