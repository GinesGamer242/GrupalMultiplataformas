using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
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
    public BulletManager bulletManager;

    public UnityEvent onPlayerWin;
    public UnityEvent onPlayerLose;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
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
