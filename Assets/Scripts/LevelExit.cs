using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    ScenePersist myScenePersist;

    private void Start()
    {
        myScenePersist = FindObjectOfType<ScenePersist>();
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        OnLevelExit();
        Destroy(myScenePersist);
    }

    private void OnLevelExit()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    
}
