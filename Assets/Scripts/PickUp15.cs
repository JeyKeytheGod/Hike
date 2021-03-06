using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUp15 : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;

    private void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.F))
            PickedUp();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("PlayerCharacter"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("PlayerCharacter"))
        {
            pickUpAllowed = false;
        }
    }

    void PickedUp()
    {
        CollectedEndGateLVL3.collValue++;
        Destroy(gameObject);
        pickUpText.gameObject.SetActive(false);
    }

}
