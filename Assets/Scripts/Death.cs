using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameManager1 gameManager;

    private void Start()
    {
        Debug.Log("Were live");
    }
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dead")
        {

            print("You're dead sucker !!!!");
            // gameManager.Restart();
        }
    }
}