
using UnityEngine;

public class ActionButonsManager : MonoBehaviour
{
#if UNITY_ANDROID
    public ActionButton m_JumpButton;
    public ActionButton m_SlideButton;
    public ActionButton m_CrouchButton;
    public ActionButton m_RunButton;

    private BasicFPCC m_BasicFPCC;

    private void Start()
    {
        m_BasicFPCC = FindObjectOfType<BasicFPCC>();
    }

    void Update()
    {
        m_BasicFPCC.inputJump = m_JumpButton.m_IsPressed;
        m_BasicFPCC.inputSlide = m_SlideButton.m_IsPressed;
        m_BasicFPCC.inputCrouch = m_CrouchButton.m_IsPressed;
        m_BasicFPCC.inputRun = m_RunButton.m_IsPressed;
    }
#endif
}

