using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCont : MonoBehaviour
{
    public TMP_Text Score;
    float timer = 0f;

    void Start()
    {
        Score.text = GlobalVariables.Score.ToString();
    }

    void Update()
    {
        if (GlobalVariables.Running)
        {
            timer += Time.deltaTime * GlobalVariables.ScoreMulti;
            GlobalVariables.Score = (int)timer;
            Score.text = GlobalVariables.Score.ToString("D5");
        }
        else if (!GlobalVariables.Running)
        {
            timer = 0f;
            GlobalVariables.Score = 00000;
            Score.text = GlobalVariables.Score.ToString("D5");
        }
    }
}
