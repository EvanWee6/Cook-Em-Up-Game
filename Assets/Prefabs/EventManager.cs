using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public SpawnFood ore;
    static public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 3)
        {
            ore.SpawnObject();
            score -= 3;
        }
    }
}
