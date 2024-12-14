using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain
{
    public static void StartGame()
    {
        Debug.Log("GameMain StartGame");
        var panel = MainLoadingPanel.Instance;
        if(panel == null)
        {
            Debug.Log("panel null");
        }
        else
        {
            MainLoadingPanel.Instance.SetProcess(50);
        }        
    }
}
