using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    //move speed
    public float moveSpeed = 10.0f;
    private Vector3 movementInput;
    //jumping related
    public float jumpForce = 2f;
    public float jumpCount = 1;
    public float maxJumpCount = 1;
    //physics
    private Rigidbody rb;
    private bool isGrounded;
    //input sys -> action
    public InputAction playerInputs;
    private playerInputs unequipped;
    private playerInputs knife;
    private playerInputs rifle;

    public struct playerActionStruct
    {
        public PlayerInput inputActions;
    }

    private void OnEnable()
    { 
        public playerInput.unequipped.move; //WASD
        public playerInput.unequipped.jump; //space
        public playerInput.unequipped.run; //shift
        public playerInput.unequipped.crouchSlide; //crtl or c
        public playerInput.unequipped.focus; //Q or RMB
        public playerInput.unequipped.punch; //V or LMB

        public playerInput.knife.move;
        public playerInput.knife.jump; 
        public playerInput.knife.run;
        public playerInput.knife.crouchSlide;
        public playerInput.knife.focus;
        public playerInput.knife.lightAttack;
        public playerInput.knife.heavyAttack;

        public playerInput.rifle.move;
        public playerInput.rifle.jump; 
        public playerInput.rifle.run;
        public playerInput.rifle.crouchSlide;
        public playerInput.rifle.punch;
        public playerInput.rifle.ads;
        public playerInput.rifle.shoot
        public playerInput.rifle.reload;


    }

    void Awake()
    {
        inputActions = new InputSystem();
        inputActions.Enable();
    }
}
