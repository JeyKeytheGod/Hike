using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedEndGateLVL3 : MonoBehaviour
{

    public GameObject ending;

    public static int collValue = 0;
    Text collectable;


    void Start()
    {
        collectable = GetComponent<Text>();
    }


    void Update()
    {
        collectable.text = "Collected " + collValue + " /15";

        if (
            collValue >= 15)
        {
            print("Finishline");
            ending.SetActive(true);
        }

    }

    void OnLevelWasLoaded()
    {
        collValue = 0;
    }

}

