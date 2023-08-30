using System.Collections;
using UnityEngine;
using Cinemachine;

public class CinemachineController : MonoBehaviour
{
    private CinemachineVirtualCamera vCam;


    private void Start()
    {
        vCam = GetComponent<CinemachineVirtualCamera>();
    }


    public void StartShake(float shakeTime)
    {
        StartCoroutine(Shake(shakeTime));
    }


    public IEnumerator Shake(float shakeTime, float amplitude = 1, float frequencie = 1)
    {
        CinemachineBasicMultiChannelPerlin noise = vCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        float elapsedTime = 0f;

        while(elapsedTime < shakeTime)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / shakeTime;
            noise.m_AmplitudeGain = Mathf.Lerp(noise.m_AmplitudeGain, amplitude, t);
            noise.m_FrequencyGain = Mathf.Lerp(noise.m_FrequencyGain, frequencie, t);
            yield return null;
        }
        
        noise.m_AmplitudeGain = 0f;
        noise.m_FrequencyGain = 0f;
    }
}
