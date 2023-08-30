using System.Collections;
using System.Collections.Generic;
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
}
