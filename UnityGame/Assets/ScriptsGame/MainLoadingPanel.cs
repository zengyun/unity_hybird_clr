using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoadingPanel : RTBase
{
    private static MainLoadingPanel _instance;
    public static MainLoadingPanel Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }
            var pfb = Resources.Load<GameObject>("MainLoading");
            GameObject obj = GameObject.Instantiate(pfb);
            obj.SetActive(true);
            _instance = obj.AddComponent<MainLoadingPanel>();
            obj.AddComponent<AutoCanvasScale>();

            return _instance;
        }
    }

    private float slider_min_width = 84;
    private float slider_max_width = 600;
    RectTransform slider_transform;
    GameObject m_slider;
    private void Awake()
    {
        name = "MainLoadingPanel";
        Debug.Log("MainLoadingPanel Awake");
        m_slider = RT.Find("root/slider").gameObject;
        m_slider.SetActive(false);
        slider_transform = RT.Find("root/slider/bar").GetComponent<RectTransform>();
    }

    public void SetProcess(float value)
    {
        if (value < 0) value = 0;
        if(value > 100) value = 100;
        m_slider.SetActive(true);
        var size = slider_transform.sizeDelta;
        size.x = slider_min_width + (slider_max_width - slider_min_width) * value / 100;
        slider_transform.sizeDelta = size;
    }
    public void SetProcessActive(bool active)
    {
        m_slider.SetActive(active);
    }
    private void OnDestroy()
    {
        if(_instance != null && _instance == this)
        {
            _instance = null;
        }
    }
}
