using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public GameObject explosion;
    public GameObject enemyObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<Player>();

            var newExplosion = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(newExplosion, 1f);

            player.getHit();

            GameManager.instance.enemySpawner.RetireEnemy(enemyObject);
        }

        if (other.CompareTag("Bullet"))
        {
            var player = GameManager.instance.player;

            var newExplosion = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(newExplosion, 1f);

            player.AddPoints(100);

            var bullet = other.transform.parent.GetComponent<BulletBehaviour>();
            bullet.StopAllCoroutines();

            GameManager.instance.bulletManager.RetireBullet(other.transform.parent.gameObject);
            GameManager.instance.enemySpawner.RetireEnemy(enemyObject);
        }
    }
}
