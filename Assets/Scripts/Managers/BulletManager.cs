using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    int maxBulletAmount;

    List<GameObject> activeBulletPool = new List<GameObject>();
    Queue<GameObject> inactiveBulletPool = new Queue<GameObject>();

    private void Start()
    {
        for (int i = 0; i < maxBulletAmount; i++)
        {
            GameObject newBullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
            newBullet.gameObject.SetActive(false);

            inactiveBulletPool.Enqueue(newBullet);
        }
    }

    public void DeployBullet(Vector3 bulletPosition, Quaternion bulletRotation)
    {
        if (activeBulletPool.Count < maxBulletAmount)
        {
            GameObject bullet = inactiveBulletPool.Dequeue();

            bullet.transform.position = bulletPosition;
            bullet.transform.rotation = bulletRotation;
            bullet.SetActive(true);

            activeBulletPool.Add(bullet);
        }
        else
        {
            Debug.LogWarning("MAX. bullet amount reached, can't deploy more bullets until one is retired.");
        }
    }

    public void RetireBullet(GameObject retiredBullet)
    {
        if (activeBulletPool.Contains(retiredBullet))
        {
            activeBulletPool.Remove(retiredBullet);

            retiredBullet.SetActive(false);

            inactiveBulletPool.Enqueue(retiredBullet);
        }
        else
        {
            Debug.LogError("This Bullet was NOT in the activeBulletPool");
        }
    }
}
