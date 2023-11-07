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

	Food CreateBurger() {
		string[] burger_ingredients = {"patty", "cheese", "bun"};
		return new Food("Burger", burger_ingredients);
	}

}

public class FoodListener : MonoBehaviour
{

	public GameObject player;

    void Start()
    {
    
	}

    // Update is called once per frame
    void Update()
    {
       if (player.transform.position.x >= 3 && player.transform.position.y >= 3) { 
			if (Input.GetKeyDown(KeyCode.E)) {
				Debug.Log("Hello");
			}

	   }
    }

	void NewFood() {
		
	}
}
