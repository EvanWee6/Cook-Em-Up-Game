using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
	public Vector2 minPosition;
	public Vector2 maxPosition;
	public GameObject Cheese;
	public GameObject Patty;
	// Start is called before the first frame update
	void GetPosition()
	{
        Vector2 randomPosition = new Vector2(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y));
		return randomPosition;
    }
	void SpawnObject()
	{
		
		GameObject cheese = Instantiate(Cheese, GetPosiiton(), Quaternion.identity);
        GameObject patty = Instantiate(Patty, GetPosiiton(), Quaternion.identity);
    }

	// Update is called once per frame
	void Update()
	{
		SpawnObject();
	}
}
