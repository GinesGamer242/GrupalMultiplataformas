using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class healthText : MonoBehaviour
{
    private TextMeshProUGUI m_HealthText;
    private Player m_Player;

    // Start is called before the first frame update
    void Start()
    {
        m_HealthText = GetComponent<TextMeshProUGUI>();
        m_Player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        m_HealthText.text = "Health: " + m_Player.health;
    }
}
