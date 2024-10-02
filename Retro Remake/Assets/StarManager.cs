
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarManager : MonoBehaviour
{
  public static StarManager instance;

    private int stars;
    [SerializeField] private TMP_Text starsDisplay;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    public void Update()
    {
        if (stars > 130)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ChangeCoins(int amount)
    {
        stars += amount;
      }
        
 }
