using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private POLY_PlayerCharacter controllerState;
    private PlayerClimb climbState;

    private void Start()
    {
        controllerState = GetComponent<POLY_PlayerCharacter>();
        climbState = GetComponent<PlayerClimb>();
    }

    public void SetState(bool state)
    {
        controllerState.active = !state;
        climbState.active = state;
    }
}
