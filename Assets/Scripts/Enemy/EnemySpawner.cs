using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int maxEnemyAmount;
    public float spawnTime = 4f;
    private float time;

    List<GameObject> activeEnemyPool = new List<GameObject>();
    Queue<GameObject> inactiveEnemyPool = new Queue<GameObject>();

    private void Start()
    {
        for (int i = 0; i < maxEnemyAmount; i++)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity);
            newEnemy.gameObject.SetActive(false);

            inactiveEnemyPool.Enqueue(newEnemy);
        }
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time > spawnTime)
        {
            time = 0;
            
            if (inactiveEnemyPool.Count > 0)
                DeployEnemy();

            spawnTime -= 0.3f;
            if(spawnTime < 0.5f)
            {
                spawnTime = 0.5f;
            }
        }
    }

    public void DeployEnemy()
    {
        if (activeEnemyPool.Count <  maxEnemyAmount)
        {
            var enemyPos = new Vector3(Random.value * 50, Random.Range(0f, 5f), Random.value * 50) + transform.position;

            GameObject enemy = inactiveEnemyPool.Dequeue();

            enemy.transform.position = enemyPos;
            enemy.SetActive(true);

            activeEnemyPool.Add(enemy);
        }
        else
        {
            Debug.LogWarning("MAX. enemy amount reached, can't deploy more enemies until one is retired.");
        }
    }

    public void RetireEnemy(GameObject retiredEnemy)
    {
        if (activeEnemyPool.Contains(retiredEnemy))
        {
            activeEnemyPool.Remove(retiredEnemy);

            retiredEnemy.SetActive(false);

            inactiveEnemyPool.Enqueue(retiredEnemy);
        }
        else
        {
            Debug.LogError("This Enemy was NOT in the activeEnemyPool");
        }
    }
}
