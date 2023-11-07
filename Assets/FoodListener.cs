using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food {

	public string _name;
	public string[] _ingredients;
	

	public Food(string name, string[] ingredients) {
		this._name = name;
		this._ingredients = ingredients;
	}

	public Food CreateBeefFood() {
		string[] beef_ingredients = {"beef", "potatos", "sauce"};
		return new Food("Beef", beef_ingredients);
	}

	public Food CreateSoupFood() {
		string[] soup_ingredients = {"broth", "veggies"};
		return new Food("Soup", soup_ingredients);
	}
}

public class FoodListener : MonoBehaviour
{

	public GameObject player;

    void Start()
    {
		Debug.Log(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       if (player.transform.position.x >= 3 && player.transform.position.y >= 3) { 
			Debug.Log("hello");
	   }
    }
}