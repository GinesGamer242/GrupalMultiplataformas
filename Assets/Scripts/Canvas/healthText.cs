using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class healthText : MonoBehaviour
{
    private TextMeshProUGUI m_HealthText;
    private Player m_Player;
    private float m_LastHealth = -1;

    void Start()
    {
        m_HealthText = GetComponent<TextMeshProUGUI>();
        m_Player = FindObjectOfType<Player>();
        m_LastHealth = m_Player.health;
        m_HealthText.SetText("Health {0]", m_LastHealth);
    }

    // SetText does not generate garbage
    void Update()
    {
        // Only refresh text when needed
        if (m_Player.health != m_LastHealth)
        {
            m_LastHealth = m_Player.health;
            m_HealthText.SetText("Health: {0}", m_LastHealth);
        }
    }
}
