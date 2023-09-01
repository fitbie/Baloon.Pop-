using UnityEngine;


/// <summary>
/// Changes the amount of health. Usually called from the OnKill/OnDie UnityEvents in inspector.
/// </summary>
public class ModifyScore : MonoBehaviour
{
    [SerializeField] private int valueToChange;


    public void ChangeScore()
    {
        GameScore.ModifyScore(valueToChange);
    }
}
