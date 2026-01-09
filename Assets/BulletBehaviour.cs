using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float m_Speed = 5f;
    public float m_LifeTime = 5f;

    private void Start()
    {
        StartCoroutine(RetireBulletCoroutine());
    }

    void Update()
    {
        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }

    IEnumerator RetireBulletCoroutine()
    {
        yield return new WaitForSeconds(m_LifeTime);

        GameManager.instance.bulletManager.RetireBullet(gameObject);
    }
}
