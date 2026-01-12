using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static UnityEditor.Progress;
using System.Text;

public class DialogueManager : MonoBehaviour
{
    public float time = 0.1f;
    public string[] dialoguePhrases;

    bool finished = false;

    private Button m_Button;
    private TextMeshProUGUI m_TextBox;

    // StringBuilder class to mitigate string concatenation memory overhead
    StringBuilder m_DialogueText;

    void Start()
    {
        m_Button = FindObjectOfType<Button>();
        m_TextBox = GetComponent<TextMeshProUGUI>();

        int totalDialogueCharCount = 0;
        foreach (var phrase in dialoguePhrases)
        {
            totalDialogueCharCount += phrase.Length + 1; // Take into account \n
        }

        // Init string builder to length of dialogue
        m_DialogueText = new StringBuilder(totalDialogueCharCount);

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
        m_TextBox.text = "";
        for (int i = 0; i < dialoguePhrases.Length; i++)
        {
            m_DialogueText.Append("\n");
            foreach (var item in dialoguePhrases[i])
            {
                m_DialogueText.Append(item);
                m_TextBox.SetText(m_DialogueText);
                yield return new WaitForSeconds(time);
            }
        }
    }
}
