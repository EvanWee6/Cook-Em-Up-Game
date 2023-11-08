using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = $"Highscore: {PlayerPrefs.GetInt("Highscore",0)}";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = SpawnFood.BurgerCount.ToString();
        CheckHighScore();
    }

    private void CheckHighScore()
    {
        if (SpawnFood.BurgerCount > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", SpawnFood.BurgerCount);
            highscoreText.text = "Highscore: " + SpawnFood.BurgerCount.ToString();
            Debug.Log(SpawnFood.BurgerCount);
        }
    }
}
