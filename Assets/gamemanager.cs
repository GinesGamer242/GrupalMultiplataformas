using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //____________________________________

    public Player player;
    public SceneAsset Menu;
    public SceneAsset Win;
    public SceneAsset Loss;

    public EnemySpawner enemySpawner;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log(Cursor.lockState);

        if (player.points >= 2000)
        {
            SceneManager.LoadScene(Win.name);
        }

        if (player.health < 0)
        {
            SceneManager.LoadScene(Loss.name);
        }
    }
}
