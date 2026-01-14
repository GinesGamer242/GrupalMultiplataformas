using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject m_Joysticks;

    private void Start()
    {
#if UNITY_ANDROID
     m_Joysticks.SetActive(true);
#else
    m_Joysticks.SetActive(false);
#endif
    }
}
