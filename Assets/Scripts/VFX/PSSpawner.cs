using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Spawn Particles Systems. Usually called from Inspector UnityEvents onDie() / OnKill()
/// </summary>
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
