using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbable : MonoBehaviour
{

    private PlayerManager climber;

    private void OnTriggerEnter(Collider other)
    {
        climber = other.GetComponent<PlayerManager>();

    }

    private void Update()
    {
        if (climber != null)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                climber.SetState(true);
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                climber.SetState(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        climber.SetState(false);
        climber = null;
    }

}
