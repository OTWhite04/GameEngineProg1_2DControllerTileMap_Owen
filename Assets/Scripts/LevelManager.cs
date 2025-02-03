using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private string spawnPointName;

    public void LoadSceneWithSpawnPoint(string sceneName, string spawnPoint)
    {
        spawnPointName = spawnPoint;

        SceneManager.sceneLoaded += OnSceneLoaded;

        SceneManager.LoadScene(sceneName);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SetPlayerToSpawn(spawnPointName);

        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void SetPlayerToSpawn(string spawnPointName)
    {
        GameObject spawnPointObject = GameObject.Find(spawnPointName);

        if (spawnPointObject != null)
        {
            Transform spawnPointTransform = spawnPointObject.transform;
            GameManager.Instance.player.transform.position = spawnPointTransform.position;
        }
        else
        {
            Debug.Log($"Error, {spawnPointName} not found in scene!");
        }
    }

}

