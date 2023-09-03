using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// This class is used to call methods that are not on the same object as the animator via UnityEvents.
/// eventIndex argument used in case multiple calls are needed in a single animation.
/// </summary>
public class CustomAnimationEvents : MonoBehaviour
{    
    [SerializeField] private UnityEvent[] animationEvents;

    public void InvokeAnimationEvent(int eventIndex)
    {
        if (eventIndex < 0 || eventIndex >= animationEvents.Length)
        {
            throw new System.IndexOutOfRangeException("Incorrect cutom animation events using!");
        }

        animationEvents[eventIndex]?.Invoke();
    }

}
