using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTime = 4f;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > spawnTime)
        {
            time = 0;
            var enemyPos = new Vector3(Random.value*50, Random.Range(0f, 5f), Random.value*50) + transform.position;
            Instantiate(enemyPrefab, enemyPos, Quaternion.identity);

            spawnTime -= 0.3f;
            if(spawnTime < 0.5f)
            {
                spawnTime = 0.5f;
            }
        }


    }
}
