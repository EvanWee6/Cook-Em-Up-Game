using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
	public Text finalScoreText;

	public void Setup()
	{
		gameObject.SetActive(true);
		finalScoreText.text = "Score; " + SpawnFood.BurgerCount.ToString();
	}

	public void RestartButton()
	{
		SceneManager.LoadScene("PreGame");
	}

	public void MainMenuButton()
	{
		SceneManager.LoadScene("Main Menu");
	}
}