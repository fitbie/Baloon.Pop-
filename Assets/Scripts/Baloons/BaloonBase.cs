using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class for baloons. I don't see the point of interfaces in such a small project, plus my version of Unity doesn't have a default implementation.
/// </summary>
public abstract class BaloonBase : MonoBehaviour
{
    public void OnMouseDown()
    {
        Pop();
    }

    public abstract void Pop();
}
