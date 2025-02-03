using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Instance for the game manager.
    public static GameManager Instance { get; private set; }

    //References for the level manager and the player.
    public LevelManager levelManager;
    public GameObject player;

    //Awake method for the singleton.
    private void Awake()
    {
        #region Singleton Pattern

        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        #endregion

    }

}