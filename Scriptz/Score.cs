using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject scoreUI;
    public GameObject highScoreUI;
    public GameObject coinsUI;

    void Update()
    {
        if (DataManagement.datamanagement.currentScore > DataManagement.datamanagement.highScore)
        {
            DataManagement.datamanagement.highScore = DataManagement.datamanagement.currentScore;
        }

        scoreUI.GetComponent<Text>().text = ("Score " + DataManagement.datamanagement.currentScore.ToString());
        highScoreUI.GetComponent<Text>().text = ("High Score " + DataManagement.datamanagement.highScore.ToString());
        coinsUI.GetComponent<Text>().text = ("Coins Collected " + DataManagement.datamanagement.coinsCollected.ToString());
    }
}