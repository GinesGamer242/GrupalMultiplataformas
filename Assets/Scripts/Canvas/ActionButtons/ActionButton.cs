
using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
#if UNITY_ANDROID

    public bool m_IsPressed = false;
    public bool m_IsHeld = false;

    private Button m_Button;
    private Image m_ButtonImage;
    private Color m_NormalColor;
    private Color m_PressedColor;

    private void Start()
    {
        m_Button = GetComponent<Button>();
        m_ButtonImage = GetComponent<Image>();
        ColorBlock buttonColors = m_Button.colors;
        m_NormalColor = buttonColors.normalColor;
        m_PressedColor = buttonColors.pressedColor;
    }

    private void Update()
    {
        if (m_IsPressed) m_ButtonImage.color = m_PressedColor;
        else m_ButtonImage.color = m_NormalColor;
    }

    public void ChangeHeldState()
    {
        m_IsHeld = !m_IsHeld;
        if (m_IsHeld) m_IsPressed = true;
        else m_IsPressed = false;
    }

    public void PressThisFrame()
    {
        m_IsPressed = true;
    }

    private void LateUpdate()
    {
        if (!m_IsHeld) m_IsPressed = false;
    }
#endif
}

