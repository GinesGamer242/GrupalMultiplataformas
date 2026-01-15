using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string[] sceneNames;

    public void GoToScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneNames[sceneIndex]);
    }
}
