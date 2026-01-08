using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public SceneAsset[] scenes;

    public void GoToScene(int sceneIndex)
    {
        SceneManager.LoadScene(scenes[sceneIndex].name);
    }
}
