using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float m_Speed;
    public float m_LifeTime;

    private void OnEnable()
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
