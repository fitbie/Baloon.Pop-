using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Attach to make frozen baloon. On kill - frozing every else baloons.
/// </summary>
[RequireComponent(typeof(BaloonBase))]
public class Freezer : MonoBehaviour
{
    private BaloonBase parentBaloon;

    private void Start()
    {
        parentBaloon = GetComponent<BaloonBase>();

        parentBaloon.baloonsEvents.onKill.AddListener(Freeze);    
    }


    private void Freeze()
    {
        foreach (BaloonBase baloon in CurrentBaloons.currentBaloons)
        {
            baloon.speedModificator.CurrentSpeed /= 2;
        }
    }
}
