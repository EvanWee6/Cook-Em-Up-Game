using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{



	public Vector2 minPosition;
	public Vector2 maxPosition;
	public GameObject Cheese;
	public GameObject Patty;
    public GameObject Buns;

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
        SpawnObject(); 
    }
    // Update is called once per frame
    void Update()
	{
        //Debug.Log(ore.GetScore());

       


    }
}
