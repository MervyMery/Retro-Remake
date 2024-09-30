using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
public class IncreaseScoreOnCollision : MonoBehaviour
{
    public Score score;
    public int scoreIncrease = 1;

        private void OnTriggerEnter2D(Collider2D collision)
    {
        score.currentScore += scoreIncrease;
    }
}
   
