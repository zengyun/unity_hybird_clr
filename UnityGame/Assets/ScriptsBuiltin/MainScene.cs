using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainScene : MonoBehaviour
{
    private void Awake()
    {
        UGFileUtil.CreateDir(UGFileUtil.WriteablePath(""));
        CheckEventSystem();
        MainHolder.Instance.StartLoadGame();
        gameObject.SetActive(true);
    }

    void CheckEventSystem()
    {
        if (EventSystem.current != null)
        {
            return;
        }

        var e = FindObjectOfType<EventSystem>();

        // Check if EventSystem is in the scene but not registered yet
        if (e != null && e.gameObject.activeSelf && e.enabled)
        {
            return;
        }

        var go = new GameObject("EventSystem[MainScene]");
        go.AddComponent<EventSystem>();
        go.AddComponent<StandaloneInputModule>();
        DontDestroyOnLoad(go);
    }
}
