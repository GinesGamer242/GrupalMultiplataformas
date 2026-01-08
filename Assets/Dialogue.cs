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

    void Start()
    {
        StartCoroutine("ShowText");
    }

    private void Update()
    {
        if(finished = true)
        {
            FindObjectOfType<Button>().gameObject.SetActive(true);
        }
    }

    IEnumerator ShowText() 
    {

        GetComponent<TextMeshProUGUI>().text = "";
        for (int i = 0; i < dialoguePhrases.Length; i++)
        {
            GetComponent<TextMeshProUGUI>().text += "\n";
            foreach (var item in dialoguePhrases[i])
            {
                GetComponent<TextMeshProUGUI>().text += item;

                yield return new WaitForSeconds(time);
            }
        }
    }
}
