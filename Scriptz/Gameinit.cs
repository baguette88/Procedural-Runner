using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameinit : MonoBehaviour
{
    public static bool gameIsPlaying;

    
    void Start()
    {
        gameIsPlaying = true;
        DataManagement.datamanagement.currentScore = 0;
        DataManagement.datamanagement.LoadData();
        Debug.Log("Game is playing");
    }

    private static object GetDatamanagement()
    {
        return DataManagement.datamanagement;
    }
}