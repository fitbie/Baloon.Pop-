using System;
using System.Collections;
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
    public class BaloonSpawnParameters
    {
        public int scoreThreshold;
        public float chance;
        public BaloonBase baloonType;
    }

    [SerializeField] private List<BaloonSpawnParameters> baloonParams = new List<BaloonSpawnParameters>();

    [Space(3)]
    public List<BaloonBase> currentBaloons = new List<BaloonBase>();
    


    public void SpawnBaloon()
    {
        BaloonBase baloon = PickBaloon();

        // Simple code that returns random Vector3 in Transforms borders.
        Vector3 position = Vector3.Lerp(minSpawnpoint.position, maxSpawnpoint.position, UnityEngine.Random.value);

        BaloonBase newBaloon = GameObject.Instantiate(baloon, position, Quaternion.identity);
        currentBaloons.Add(newBaloon);
    }


    private BaloonBase PickBaloon()
    {
        int score = GameScore.Score;
        float totalChance = 0f;

        // Create total chance to spawn.
        foreach (BaloonSpawnParameters baloonParam in baloonParams)
        {
            if (baloonParam.scoreThreshold >= score)
            {
                totalChance += baloonParam.chance;
            }
        }

        float randomValue = UnityEngine.Random.value;
        float accumulatedChance = 0f;

        foreach (BaloonSpawnParameters baloonParam in baloonParams)
        {
            if (baloonParam.scoreThreshold >= score)
            {
                float normalizedChance = baloonParam.chance / totalChance;
                accumulatedChance += normalizedChance;

                if (normalizedChance >= randomValue)
                {
                    return baloonParam.baloonType;
                }
            }
        }

        // Default baloon
        return baloonParams[0].baloonType;
    }

}
