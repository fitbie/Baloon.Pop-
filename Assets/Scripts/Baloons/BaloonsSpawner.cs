using System;
using System.Collections.Generic;
using UnityEngine;

public class BaloonsSpawner : MonoBehaviour
{
    // Transform for convenience in editor.
    [SerializeField] private Transform minSpawnpoint;
    [SerializeField] private Transform maxSpawnpoint;

    /// <summary>
    /// This class is used to specify the score threshold + chance for balloon spawning.
    /// We don't want the hardest types of balloons to spawn immediately at the start of the game.
    /// </summary>
    [Serializable]
    public class BaloonSpawnChance
    {
        public int scoreThreshold;
        public float chance;
        public BaloonBase baloonType;
    }

    [SerializeField] private List<BaloonSpawnChance> baloonTypes = new List<BaloonSpawnChance>();

    [Space(3)]
    public List<BaloonBase> currentBaloons = new List<BaloonBase>();
     
    
    public void SpawnBaloon(BaloonBase baloon)
    {
        // Simple code that returns random Vector3 in Transforms borders.
        Vector3 position = Vector3.Lerp(minSpawnpoint.position, maxSpawnpoint.position, UnityEngine.Random.value);

        GameObject.Instantiate(baloon, position, Quaternion.identity);
    }
    
}
