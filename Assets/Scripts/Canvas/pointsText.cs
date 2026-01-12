using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointsText : MonoBehaviour
{
    private TextMeshProUGUI m_ScoreText;
    private Player m_Player;
    private int m_LastPoints = -1;

    void Start()
    {
        m_ScoreText = GetComponent<TextMeshProUGUI>();
        m_Player = FindObjectOfType<Player>();
        m_LastPoints = m_Player.points;
        m_ScoreText.SetText("Score: {0}", m_LastPoints);
    }


    void Update()
    {
        // Only refresh when needed
        if (m_Player.points != m_LastPoints)
        {
            m_LastPoints = m_Player.points;
            m_ScoreText.SetText("Score: {0}", m_LastPoints);
        }
    }
}
