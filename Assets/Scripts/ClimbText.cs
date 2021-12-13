using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClimbText : MonoBehaviour
{
    [SerializeField]
    private Text climbText;

    private void Start()
    {
        climbText.gameObject.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("PlayerCharacter"))
        {
            climbText.gameObject.SetActive(true);
   
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("PlayerCharacter"))
        {
            climbText.gameObject.SetActive(false);
        }
    }

}
