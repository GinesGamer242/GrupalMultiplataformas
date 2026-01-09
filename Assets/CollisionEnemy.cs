using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<Player>();
            Instantiate(explosion, transform.position, Quaternion.identity);
            player.getHit();
            player.health -= 10;
            GameManager.instance.enemySpawner.RetireEnemy(gameObject);
        }
        if (other.CompareTag("Bullet"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            var player = FindObjectOfType<Player>();
            player.AddPoints(100);
            var bullet = other.transform.parent.GetComponent<BulletBehaviour>();
            Destroy(bullet.gameObject);
            GameManager.instance.enemySpawner.RetireEnemy(gameObject);
        }
    }
}
