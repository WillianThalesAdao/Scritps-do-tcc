using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovimentacao : MonoBehaviour 
{

public CharacterController2D controller;

public float runSpeed = 40f;
float horizontalMove = 0f;
bool jumo = false;
bool crouch = false;
void Update() {
    input.GetAxisRaw("Horizontal") * runSpeed;
    if (input.GetButtonDown"Jump"))
    {
        jump = true;
    }

    if (input.GetButtonDown("Crouch"))
    {
        crouch = true;
    } else if (input.GetButtonUp("Crouch"))
    {
        crouch = false;
    }
}
void FixedUpdate() 
{
//move o personagem
controller.Move(horizontalMove * Time.fixeDeltaTime, crouch, jump);
jump = false;
}
}