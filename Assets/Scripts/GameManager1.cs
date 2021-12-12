using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public GameObject winScreen;
    bool gameEnd = false;

    public float restartDelay = 1f;

    public void CompleteLVL()
    {
        // Lock cursor
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        Debug.Log("LEVEL FINISHED !!!");
        winScreen.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Player dead !!!");
        }
    }


}
