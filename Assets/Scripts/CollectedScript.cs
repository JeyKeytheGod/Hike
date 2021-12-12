using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedScript : MonoBehaviour
{

    public MainMenu mainMenu;
    public static int collValue = 0;
    Text collectable;


    void Start()
    {
        collectable = GetComponent<Text>();
    }

    
    void Update()
    {
        collectable.text = "Collected " + collValue + " /10";
    }

    void OnLevelWasLoaded()
    {
        collValue = 0;
    }

}
