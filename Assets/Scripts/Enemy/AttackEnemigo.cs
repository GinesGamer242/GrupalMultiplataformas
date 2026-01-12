using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemigo : MonoBehaviour
{
    public float m_Speed = 1f;
    public BasicFPCC player;

    private void Start()
    {
        player = FindObjectOfType<BasicFPCC>();
    }

    void Update()
    {

        transform.LookAt(player.transform);


        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }
}
