using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointsText : MonoBehaviour
{
    private TextMeshProUGUI m_ScoreText;
    private Player m_Player;

    // Start is called before the first frame update
    void Start()
    {
        m_ScoreText = GetComponent<TextMeshProUGUI>();
        m_Player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        m_ScoreText.text = "Score: " + m_Player.points;
    }
}
