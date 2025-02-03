using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //Private string for the name of the spawn point.
    private string spawnPointName;

    //Load scene with spawn point method.
    public void LoadSceneWithSpawnPoint(string sceneName, string spawnPoint)
    {
        //making the spawn point name be equal to the spawn point.
        spawnPointName = spawnPoint;

        //Scene manager subscribing to the on scene loaded method.
        SceneManager.sceneLoaded += OnSceneLoaded;
        //Loads the scene with the scenes name.
        SceneManager.LoadScene(sceneName);
    }

    //Method for on scene being loaded.
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //Calling the set player to spawn method with the spawn point name.
        SetPlayerToSpawn(spawnPointName);

        //Unsubscribing from the on scene loaded method.
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    //Method for setting the player to the spawn with the spawn point name.
    public void SetPlayerToSpawn(string spawnPointName)
    {

        //Finding the spawn point name for the spawn point object.
        GameObject spawnPointObject = GameObject.Find(spawnPointName);

        //If statement for the spawn point object not being null.
        if (spawnPointObject != null)
        {
            //Making the spawn point transform equal to the spawn point object transform.
            Transform spawnPointTransform = spawnPointObject.transform;
            //Changes the players position to the spawn point.
            GameManager.Instance.player.transform.position = spawnPointTransform.position;
        }
        //Else statement for the scene point name not being found.
        else
        {
            Debug.Log($"Error, {spawnPointName} not found in scene!");
        }
    }

}

