using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class DialogueManager : MonoBehaviour
{
    public float time = 0.1f;
    public string[] dialoguePhrases;

    bool finished = false;

    private Button m_Button;
    private TextMeshProUGUI m_Text;

    void Start()
    {
        m_Button = FindObjectOfType<Button>();
        m_Text = GetComponent<TextMeshProUGUI>();
        StartCoroutine("ShowText");
    }

    private void Update()
    {
        if (finished == true)
        {
            m_Button.gameObject.SetActive(true);
        }
    }

    IEnumerator ShowText() 
    {

        m_Text.text = "";
        for (int i = 0; i < dialoguePhrases.Length; i++)
        {
            m_Text.text += "\n";
            foreach (var item in dialoguePhrases[i])
            {
                m_Text.text += item;
                yield return new WaitForSeconds(time);
            }
        }
    }
}
