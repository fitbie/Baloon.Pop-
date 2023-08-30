using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BaloonsSpawner))]
public class SpawnerTimer : MonoBehaviour
{
    [SerializeField] private float lowerTimer;
    [SerializeField] private float upperTimer;
    private float timer;

    private BaloonsSpawner spawner; 


    private void Start()
    {
        spawner = GetComponent<BaloonsSpawner>();
    }


    public void SetTimer()
    {
        timer = Random.Range(lowerTimer, upperTimer);
    }

    
    void Update()
    {
        if (PauseController.paused) { return; }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            spawner.SpawnBaloon();
            
            SetTimer();
        }
    }
}
