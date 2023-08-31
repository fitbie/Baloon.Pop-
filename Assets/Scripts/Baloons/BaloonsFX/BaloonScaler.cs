using System.Collections;
using UnityEngine;


/// <summary>
/// ScaleUp baloon when tap on it.
/// </summary>
public class BaloonScaler : MonoBehaviour
{
    private BaloonBase baloonBase;
    
    [SerializeField] private bool autoConnectToOnPopEvent = true;

    [Space(3)]
    [SerializeField] private float scaleFactor = 1.3f;
    [SerializeField] private float scaleTime = 0.2f;

    private Coroutine scaleRoutine;


    private void Start()
    {
        if (autoConnectToOnPopEvent)
        {
            if (TryGetComponent<BaloonBase>(out BaloonBase b))
            {
                baloonBase = b;
            }

            baloonBase.baloonsEvents.onPop.AddListener(ScaleUp);
        }
    }


    private void ScaleUp()
    {
        if (scaleRoutine != null) { StopCoroutine(scaleRoutine); }
        scaleRoutine = StartCoroutine(ScaleUpRoutine());
    }


    private IEnumerator ScaleUpRoutine()
    {
        Vector3 currentScale = transform.localScale;
        Vector3 newScale = currentScale * scaleFactor;

        float elapsedTime = 0f;
        while (elapsedTime <= scaleTime)
        {
            transform.localScale = Vector3.Lerp(currentScale, newScale, elapsedTime);

            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
