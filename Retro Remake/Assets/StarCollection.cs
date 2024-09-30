using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCollection : MonoBehaviour
{
    public Text score;
    private int scoreValue = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Star")
        {
            collision.gameObject.SetActive(false);
            scoreValue += 1;
            SetScore();
        }
    }
    void SetScore()
    {
        score.text = "Star: " + scoreValue;
    }
}
