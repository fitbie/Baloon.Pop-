using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton Initialization

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null) { throw new ArgumentNullException("GameManager doesn't exist"); }

            return instance; 
        }
    }

    private void Awake() 
    {
        instance = this;
    }

    #endregion


    public GameState gameState;
    public BaloonsSpawner baloonsSpawner;
    public UserUIController userUI;
    public CinemachineController cinemachineController;
}
