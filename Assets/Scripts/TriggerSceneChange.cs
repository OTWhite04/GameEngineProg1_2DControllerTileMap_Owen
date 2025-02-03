using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneChange : MonoBehaviour
{
    //String for the scene being loaded and the spawn point.
    public string sceneToLoad;
    public string spawnPoint;

    //Method for hitting a trigger in 2D.
    private void OnTriggerEnter2D(Collider2D other)
    {

        //If statement for the player enter the level changing triggers.
        if(other.tag == "Player")
        {
            GameManager.Instance.levelManager.LoadSceneWithSpawnPoint(sceneToLoad, spawnPoint);
        }
    }
}
