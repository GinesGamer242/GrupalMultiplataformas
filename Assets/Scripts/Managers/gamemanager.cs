using UnityEngine;
using UnityEngine.Events;

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

    public EnemySpawner enemySpawner;
    public BulletManager bulletManager;

    public UnityEvent onPlayerWin;
    public UnityEvent onPlayerLose;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
