using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClimb : MonoBehaviour
{

    CharacterController characterController;
    public bool active = false;
    public float climbSpeed;
    private float inputY;
    private Vector3 moveDir;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        moveDir = new Vector3(0, climbSpeed, 0);
    }

    void Update()
    {
        if (active)
        {
            inputY = Input.GetAxisRaw("Vertical");

            moveDir = new Vector3(0, climbSpeed * inputY, 0);

            if (inputY != 0)
            {
                characterController.Move(moveDir * Time.deltaTime);
            }
        }
    }
}
