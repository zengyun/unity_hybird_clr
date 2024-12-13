using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoCanvasScale : MonoBehaviour
{
    public static float s_designWidth = 1080;
    public static float s_designHeight = 1920;

    private Canvas m_canvas;
    private CanvasScaler m_canvasScale;
    private void Awake()
    {
        m_canvas = gameObject.GetComponent<Canvas>();
        if (m_canvas == null)
        {
            m_canvas = gameObject.AddComponent<Canvas>();
        }
        m_canvasScale = this.gameObject.GetComponent<CanvasScaler>();
        if (m_canvasScale == null)
        {
            m_canvasScale = gameObject.AddComponent<CanvasScaler>();
        }
        m_canvasScale.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        m_canvasScale.referenceResolution = new Vector2(s_designWidth, s_designHeight);
        if ((float)Screen.height / Screen.width > 1.85f)
        {
            m_canvasScale.matchWidthOrHeight = 0;
        }
        else
        {
            m_canvasScale.matchWidthOrHeight = 1;
        }
    }

    public void InitCanvas(int planDistance, int orderInLayer)
    {
        m_canvas.planeDistance = planDistance;
        m_canvas.sortingOrder = orderInLayer;
    }
}
