using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnFood : MonoBehaviour
{
    static private int score;
    static public int BurgerCount;

	public static void AddScore(int num) {
		score += num;
	}

	public int GetScore() {
		return score;
	}

	public static void SetScore(int num) {
		score = num;
	}


    public Vector2 minPosition;
	public Vector2 maxPosition;
	public GameObject Cheese;
	public GameObject Patty;
    public GameObject Buns;
    public bool canSpawn;

    Vector2 GetPosition()
	{
        Vector2 randomPosition = new Vector2(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y));
		return randomPosition;
    }

   public void SpawnObject()
	{
		Instantiate(Cheese, GetPosition(), Quaternion.identity);
        Instantiate(Patty, GetPosition(), Quaternion.identity);
        Instantiate(Buns, GetPosition(), Quaternion.identity);
    }void Start()
    {
        TimerManager.GameOver = false;
        BurgerCount = 0;
        SpawnObject();

    }
    // Update is called once per frame
    void Update()
	{
     

        if (score == 3)
        {
            BurgerCount += 1;
            SpawnObject();
			AddScore(-3);
        }
    } 
}
