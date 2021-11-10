using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drowning : MonoBehaviour
{
    public GameManager1 gameManager;
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.name == "PlayerCharacter")
        {

            print("You're dead sucker !!!!");
            gameManager.Restart();
        }


    }
}
