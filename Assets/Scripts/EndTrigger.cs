using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndTrigger : MonoBehaviour
{

    public GameManager1 gameManager;

    private void OnTriggerEnter()
    {
        gameManager.CompleteLVL();
    }
}
