using System.Collections.Generic;
using UnityEngine;

public class PSSpawner : MonoBehaviour
{
    [SerializeField] private List<ParticleSystem> partyiclesToSpawn = new List<ParticleSystem>();


    public void SpawnParticles()
    {
        foreach (ParticleSystem ps in partyiclesToSpawn)
        {
            GameObject.Instantiate(ps, transform.position, Quaternion.identity);
        }
    }
}
