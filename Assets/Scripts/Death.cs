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
    void OnCollisionEnter(Collision collisionInfo)
    {
         
        if (collisionInfo.collider.tag == "Dead")
        {

            print("You're dead sucker !!!!");
           // gameManager.Restart();
        }

    }   
}
