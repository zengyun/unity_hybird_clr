using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain
{
    public static void StartGame()
    {
        Debug.Log("GameMain StartGame");
        MainLoadingPanel.Instance.SetProcess(50);
    }
}
