using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public GameManager1 gameManager;
    public GameObject deathScreen;
    public GameObject gameUI;
    

    private void Start()
    {
        Debug.Log("Were live");
    }
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dead")
        {
            // Lock cursor
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;

            print("You're dead sucker !!!!");
            gameUI.SetActive(false);
            deathScreen.SetActive(true);

        }
    }
}
