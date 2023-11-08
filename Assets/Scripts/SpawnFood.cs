using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
	public Vector2 minPosition;
	public Vector2 maxPosition;
	public GameObject Cheese;
	public GameObject Patty;

    Vector2 GetPosition()
	{
        Vector2 randomPosition = new Vector2(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y));
		return randomPosition;
    }

    public void SpawnObject()
	{
		
		GameObject cheese = Instantiate(Cheese, GetPosition(), Quaternion.identity);
        GameObject patty = Instantiate(Patty, GetPosition(), Quaternion.identity);
    }

	// Update is called once per frame
	void Update()
	{
        if (Input.GetKeyUp(KeyCode.Space))
            SpawnObject();
       


    }
}
