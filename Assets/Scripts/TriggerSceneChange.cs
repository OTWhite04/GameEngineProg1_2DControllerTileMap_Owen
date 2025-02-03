using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneChange : MonoBehaviour
{
    public string sceneToLoad;
    public string spawnPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
