using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject m_AndroidUI;

    private void Start()
    {
#if UNITY_ANDROID
        m_AndroidUI.SetActive(true);
#else
        m_AndroidUI.SetActive(false);
#endif
    }
}
