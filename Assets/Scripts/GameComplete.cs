using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{
    public GameObject gameCompleted;
    public GameObject gameUI;

    private void OnTriggerEnter()
    {
        gameCompleted.SetActive(true);
        gameUI.SetActive(false);
    }


}
