using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float m_Speed = 5f;
    public float m_LifeTime = 5f;

    private void Start()
    {
        Destroy(gameObject, m_LifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }
}
