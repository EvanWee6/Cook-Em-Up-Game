using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour 
{
    // Start is called before the first frame update
    static public float CurrentTime = 0f;
    private float _startingTime = 20f;
    public Text timerText;
    public GameOverScreen GameOverScreen;
    public Movement Movement;
    public SpawnFood SpawnFood;

    static public bool GameOver = false;



    void Start()
    {
        CurrentTime = _startingTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= 1 * Time.deltaTime; 
        timerText.text = CurrentTime.ToString("0.0");

        if (CurrentTime <= 4)
        {
            timerText.color = Color.red;
        }

        if (CurrentTime <= 0)
        {
            CurrentTime = 0;
            GameOver = true;
            SpawnFood.score = 0;
            Movement.DisablePlayerMovement();
            GameOverScreen.Setup();
          
            
        }
    }


}
