using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int PlayerScore = 0;
    private int ComputerScore = 0;

    public Text PlayerScoreText;
    public Text ComputerScoreText;

    public void PlayerGoal()
    {
        PlayerScore++;
        PlayerScoreText.text = PlayerScore.ToString();
    }

    public void ComputerGoal()
    {
        ComputerScore++;
        ComputerScoreText.text = ComputerScore.ToString();
    }
}
