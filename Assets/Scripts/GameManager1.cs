using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    bool gameEnd = false;

    public float restartDelay = 1f;

    public void CompleteLVL()
    {
        Debug.Log("LEVEL FINISHED !!!");
    }

    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Player dead !!!");
            Invoke("Restart", restartDelay);
        }
    }


}
