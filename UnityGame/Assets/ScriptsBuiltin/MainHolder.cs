using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Networking;

public class MainHolder : MonoBehaviour
{
    static MainHolder _instance;
    public static MainHolder Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject obj = new GameObject();
                obj.AddComponent<MainHolder>();
            }
            return _instance;
        }
    }
    public static string AssemblyFile = "ScriptsGame.dll.bytes";
    private void Awake()
    {
        if(_instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        _instance = this;
        name = "MainHolder";
        DontDestroyOnLoad(gameObject);
    }

    private Assembly m_assembly;
    public void StartLoadGame()
    {
        //if (Application.isEditor)
        //{
        //    m_assembly = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "ScriptsGame");
        //    _startGame();
        //    return;
        //}

        string file = Path.Combine(UGFileUtil.ResPath_OutApp, AssemblyFile);
        if (!File.Exists(file))
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                StartCoroutine(_loadAssemblySync());
                return;
            }
            file = Path.Combine(UGFileUtil.ResPath_InApp, AssemblyFile);
        }
        _loadGameAssembly(File.ReadAllBytes(file));
    }

    private IEnumerator _loadAssemblySync()
    {
        string assemblyFile = Path.Combine(UGFileUtil.ResPath_InApp, AssemblyFile);
        UnityWebRequest request = new UnityWebRequest(assemblyFile);
        request.downloadHandler = new DownloadHandlerBuffer();
        yield return request.SendWebRequest();
        _loadGameAssembly(request.downloadHandler.data);
    }

    private void _loadGameAssembly(byte[] data)
    {
        m_assembly = Assembly.Load(data);
        _startGame();
    }

    private void _startGame()
    {
        Type type = m_assembly.GetType("GameMain");
        type.GetMethod("StartGame").Invoke(null, null);
    }
}
