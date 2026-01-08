using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemigo : MonoBehaviour
{
    public float m_Speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var player = FindObjectOfType<BasicFPCC>();

        transform.LookAt(player.transform);


        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }
}
