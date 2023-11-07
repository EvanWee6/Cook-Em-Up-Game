using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject Cheese;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Cheese);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
