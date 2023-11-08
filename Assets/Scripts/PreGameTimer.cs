using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PreGameTimer : MonoBehaviour 
{
    // Start is called before the first frame update
    private float _currentTime = 0f;
    private float _startingTime = 3f;
    public Text timerText;



    void Start()
    {
        _currentTime = _startingTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime -= 1 * Time.deltaTime; 
        timerText.text = _currentTime.ToString("0.0");

        if (_currentTime <= 0)
        {
            _currentTime = 0; 
            SceneManager.LoadScene("Game");
            
        }
    }


}
